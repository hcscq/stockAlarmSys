using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using stockAlarmSys.Models;

namespace stockAlarmSys
{
    public partial class GroupConfig : Form
    {
        private Guid guid_CurEdit = Guid.Empty;
        private List<GroupModel> List_gm=new List<GroupModel> ();
        private List<GroupConfigAddrModel> list_addr = new List<GroupConfigAddrModel>();
        private Color color_gMain = Color.Gray;
        //private GroupConfigAddrModel cur_gCAModel = null;
        public GroupConfig()
        {
            InitializeComponent();
            InitalInfo();
        }
        private void InitalInfo()
        {
            dgv_groupList.MultiSelect = false;
            btn_add2G.Enabled = false;
            btn_remove.Enabled = false;
            lv_addrUnsel.MultiSelect = false;
            lv_addrSel.MultiSelect = false;
            lv_addrUnsel.HideSelection = false;
            lv_addrSel.HideSelection = false;
            btn_setMainG.Enabled = false;
            btn_saveAlter.Enabled = false;

            //lv_addrUnsel.FullRowSelect = true;
            //lv_addrSel.FullRowSelect = true;
            lv_addrSel.SelectedIndexChanged += Lv_addrSel_SelectedIndexChanged;
            lv_addrUnsel.SelectedIndexChanged += Lv_addrUnsel_SelectedIndexChanged;
            dataRefresh();

            ColumnHeader[] ch = { new ColumnHeader(), new ColumnHeader() };
            ch[0].Text = "内码";
            ch[0].Name = "ID";
            ch[0].Width = 40;

            ch[1].Text = "收件地址";
            ch[1].Name = "addr";

            ch[1].Width = 105;
            lv_addrUnsel.Columns.AddRange(ch);
            lv_addrUnsel.HeaderStyle = ColumnHeaderStyle.Clickable;
            lv_addrUnsel.View = View.Details;
            lv_addrUnsel.Scrollable = true;
            lv_addrUnsel.FullRowSelect = true; ;

            ColumnHeader[] ch1 = { new ColumnHeader(), new ColumnHeader() ,new ColumnHeader ()};
            ch1[0].Text = "内码";
            ch1[0].Name = "ID";
            ch1[0].Width = 40;

            ch1[1].Text = "抄送";
            ch1[1].Name = "copy";
            ch1[1].Width = 40;


            ch1[2].Text = "收件地址";
            ch1[2].Name = "addr";
            ch1[2].Width = 105;
            lv_addrSel.Columns.AddRange(ch1);
            lv_addrSel.HeaderStyle = ColumnHeaderStyle.Clickable;
            lv_addrSel.View = View.Details;
            lv_addrSel.Scrollable = true;
            lv_addrSel.FullRowSelect = true; ;

            listViewRefresh();
        }

        private void Lv_addrUnsel_SelectedIndexChanged(object sender, EventArgs e)
        {
            //btn_remove.Enabled = lv_addrSel.Focused;

            if (lv_addrUnsel.SelectedItems.Count > 0)
            {
                lv_addrSel.SelectedItems.Clear();
                btn_add2G.Enabled = true;
            }
            else
                btn_add2G.Enabled = false;
        }

        private void Lv_addrSel_SelectedIndexChanged(object sender, EventArgs e)
        {
            //btn_add2G.Enabled = lv_addrUnsel.Focused;

            if (lv_addrSel.SelectedItems.Count > 0)
            {
                lv_addrUnsel.SelectedItems.Clear();
                btn_remove.Enabled = true;
                btn_setMainG.Enabled = true;
            }
            else {
                btn_remove.Enabled = false;
                btn_setMainG.Enabled = false;
            }
        }

        private void dataRefresh()
        {
            using (ksoaContext db = new ksoaContext())
            {
                List_gm.Clear();
                var query1 = (from q in db.alarmAddr_realations select q).ToList();
                var query2 = from q in db.alarmAddr_realationsD select q;
                GroupModel gm;//= new GroupModel();
                foreach (var item in query1)
                {
                    gm = new GroupModel();
                    gm.detials = new List<alarmAddr_realationsD>();
                    gm.main = item;
                    gm.detials = query2.Where(q => q.guid == item.guid).ToList();
                    List_gm.Add(gm);
                }

                list_addr = (from q in db.alarm_MailAddr where q.IsDeleted == false select new GroupConfigAddrModel{ addr = q.mailAddress, bol_selected = false, bol_mainAddr = false,Id=q.ID }).ToList() ;               
                dgv_groupList.DataSource = query1;
            }
        }
        private void dgv_groupList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_groupList.SelectedRows.Count>0)
            {
                //guid_CurEdit =Guid.Parse(dgv_groupList.SelectedRows[0].Cells["guid"].Value.ToString());
                var model = List_gm.First(q=>q.main.guid== Guid.Parse(dgv_groupList.SelectedRows[0].Cells["guid"].Value.ToString()));
                if (model != null)
                {
                    
                    getOrSetFormModel(ref model, false);
                    btn_saveAlter.Enabled = true;
                }
                else
                {
                    MessageBox.Show("获取分组详情失败,请尝试刷新重试!", "提示");
                    return;
                }

            }
        }
        private bool getOrSetFormModel(ref GroupModel model,bool get=true,bool newModel=false)
        {

            if (get)
            {
                if (list_addr == null || list_addr.Count() <= 0)
                    throw new Exception("Get model:The list_addr is empty.");
                if (model == null)
                    model = new GroupModel();
                Guid loc_guid =newModel? Guid.NewGuid():guid_CurEdit;
                if (Guid.Empty==loc_guid) throw new Exception("Get model:The guid is empty.");
                model.detials = new List<alarmAddr_realationsD>();
                model.main = new alarmAddr_realations();
                if (list_addr.Exists(q => q.bol_mainAddr))
                    model.main.addr_Id_Main = list_addr.First(q => q.bol_mainAddr == true).Id;
                else
                    model.main.addr_Id_Main = list_addr[0].Id;
                model.main.guid = loc_guid;// Guid.NewGuid();
                model.main.relation_Type = 0;
                model.main.show_Name = tb_groupName.Text.Trim();

                model.detials = new List<alarmAddr_realationsD>();
                model.detials = list_addr.Where(q => q.bol_selected == true).Select(q => new alarmAddr_realationsD { addr_Id_attached = q.Id, guid = loc_guid }).ToList();
            }
            else
            {
                if (list_addr == null || list_addr.Count() <= 0||model==null)
                    throw new Exception("Set model:The list_addr is empty.");
                GroupModel loc_gm = model;
                tb_groupName.Text = model.main.show_Name;
                guid_CurEdit = model.main.guid;
                int loc_index = -1;
                //var query = from q in list_addr
                //            from p in loc_gm.detials
                //            select q;//list_addr.Except(model.detials,new () => { });
                list_addr = (from q in list_addr select new GroupConfigAddrModel { addr = q.addr, bol_selected = false, bol_mainAddr = false, Id = q.Id }).ToList();
                foreach (var item in model.detials)
                {
                    loc_index = list_addr.FindIndex(q=>q.Id==item.addr_Id_attached);
                    if(loc_index>=0)
                        list_addr[loc_index].bol_selected = true;
                }
                loc_index = list_addr.FindIndex(q => q.Id == loc_gm.main.addr_Id_Main);
                if (loc_index >= 0)
                    list_addr[loc_index].bol_mainAddr = true;
                listViewRefresh();

            }

            return true;
        }
        private void listViewRefresh()
        {
            if (list_addr.Count <= 0)
                return;
            ListViewItem lv_item;
            lv_addrSel.Items.Clear();
            lv_addrUnsel.Items.Clear();
            foreach (var item in list_addr)
            {
                lv_item = new ListViewItem(item.Id.ToString());
                lv_item.SubItems.Add(item.addr);
                lv_item.Name = item.Id.ToString();
                if (!item.bol_selected)
                {   
                    lv_item.SubItems.Add(item.addr);
                    lv_addrUnsel.Items.Add(lv_item);

                }
                else
                {
                    if (item.bol_mainAddr)
                        lv_item.BackColor = color_gMain;
                    lv_addrSel.Items.Add(lv_item);

                }
            }
            btn_add2G.Enabled = false;
            btn_remove.Enabled = false;
            btn_setMainG.Enabled = false;
        }
        private void btn_saveAlter_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Enabled = false;
            GroupModel gm = new GroupModel();
            getOrSetFormModel(ref gm);
            alarmAddr_realations ar ;
            using (ksoaContext db=new ksoaContext ())
            {
                ar = db.alarmAddr_realations.Find(gm.main.guid,gm.main.relation_Type);
                ar.show_Name = gm.main.show_Name;
                ar.addr_Id_Main = gm.main.addr_Id_Main;
                db.alarmAddr_realationsD.RemoveRange(db.alarmAddr_realationsD.Where(q=>q.guid==gm.main.guid));
                db.alarmAddr_realationsD.AddRange(gm.detials);
                if (db.SaveChanges() <= 0)
                {
                    MessageBox.Show("保存失败!", "提示");
                }
                else
                {
                    guid_CurEdit = Guid.Empty;
                    MessageBox.Show("保存成功!", "提示"); 
                    dataRefresh();
                    gm = new GroupModel();
                    gm.detials = new List<alarmAddr_realationsD>();
                    gm.main = new alarmAddr_realations();
                    getOrSetFormModel(ref gm,false);
                    //listViewRefresh();
                }
            }

            
            btn.Enabled = false;
        }

        private void btn_addNewG_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Enabled = false;
            guid_CurEdit = Guid.Empty;
            GroupModel gm = new GroupModel();
            getOrSetFormModel(ref gm, true, true);
            using (ksoaContext db=new ksoaContext ())
            {
                db.alarmAddr_realations.Add(gm.main);
                db.alarmAddr_realationsD.AddRange(gm.detials);
                if (db.SaveChanges() > 0)
                {
                    MessageBox.Show("添加组成功!", "提示");
                    dataRefresh();
                    gm = new GroupModel();
                    gm.detials = new List<alarmAddr_realationsD>();
                    gm.main = new alarmAddr_realations();
                    getOrSetFormModel(ref gm, false);
                    //listViewRefresh();
                }
                else MessageBox.Show("添加组失败!", "提示");
            }
            btn.Enabled = true;
        }

        private void btn_add2G_Click(object sender, EventArgs e)
        {

            if (lv_addrUnsel.SelectedItems.Count <= 0)
                return;
            list_addr[list_addr.FindIndex(q => q.Id == int.Parse(lv_addrUnsel.SelectedItems[0].Text))].bol_selected = true;
            listViewRefresh();
            if (lv_addrUnsel.Items.Count <= 0)
                ((Button)sender).Enabled = false;
            if (lv_addrUnsel.Items.Count > 0 && lv_addrUnsel.SelectedItems.Count <= 0)
                lv_addrUnsel.Items[0].Selected = true; 
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (lv_addrSel.SelectedItems.Count <= 0)
                return;
            int loc_index = list_addr.FindIndex(q => q.Id == int.Parse(lv_addrSel.SelectedItems[0].Text));
            list_addr[loc_index].bol_selected = false;
            list_addr[loc_index].bol_mainAddr = false;
            listViewRefresh();
            if (lv_addrSel.Items.Count <= 0)
            {
                btn_setMainG.Enabled = false;
                ((Button)sender).Enabled = false;
            }
            if (lv_addrSel.Items.Count > 0 && lv_addrSel.SelectedItems.Count <= 0)
                lv_addrSel.Items[0].Selected = true; 
        }

        private void btn_setMainG_Click(object sender, EventArgs e)
        {
            int new_index=-1,old_index=-1;
            if (lv_addrSel.SelectedItems.Count<=0||(new_index = list_addr.FindIndex(q => q.Id == int.Parse(lv_addrSel.SelectedItems[0].Text)))<0)
                return;
            old_index=list_addr.FindIndex(q=>q.bol_mainAddr==true);
            if (old_index >= 0)
            {
                list_addr[old_index].bol_mainAddr = false;
                lv_addrSel.Items[list_addr[old_index].Id.ToString()].BackColor = Color.White;
            }

            list_addr[new_index].bol_mainAddr = true;
            lv_addrSel.SelectedItems[0].BackColor = color_gMain;
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Enabled = false;
            dataRefresh();
            btn.Enabled = true;
        }

        private void btn_delGroup_Click(object sender, EventArgs e)
        {
            MessageBox.Show("暂未开放!","提示");

        }
    }
}
