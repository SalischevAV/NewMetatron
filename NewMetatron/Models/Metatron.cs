namespace NewMetatron.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Web.Mvc;

    [AllowAnonymous]
    public partial class Metatron : DbContext
    {
        public Metatron()
            : base("name=Metatron")
        {
        }

        public virtual DbSet<balances_settings> balances_settings { get; set; }
        public virtual DbSet<brand> brands { get; set; }
        public virtual DbSet<c_comments> c_comments { get; set; }
        public virtual DbSet<cdr> cdrs { get; set; }
        public virtual DbSet<cdr_city> cdr_city { get; set; }
        public virtual DbSet<cdr_goal> cdr_goal { get; set; }
        public virtual DbSet<cdr_offline> cdr_offline { get; set; }
        public virtual DbSet<cdr_real_dst> cdr_real_dst { get; set; }
        public virtual DbSet<city> cities { get; set; }
        public virtual DbSet<department> departments { get; set; }
        public virtual DbSet<dst_codes> dst_codes { get; set; }
        public virtual DbSet<dst_groups> dst_groups { get; set; }
        public virtual DbSet<dst2group> dst2group { get; set; }
        public virtual DbSet<fo_orders> fo_orders { get; set; }
        public virtual DbSet<fo_smsbuffer> fo_smsbuffer { get; set; }
        public virtual DbSet<fo_smsbystatus> fo_smsbystatus { get; set; }
        public virtual DbSet<goal> goals { get; set; }
        public virtual DbSet<group> groups { get; set; }
        public virtual DbSet<groups_permissions> groups_permissions { get; set; }
        public virtual DbSet<gsmgateway> gsmgateways { get; set; }
        public virtual DbSet<last_calls> last_calls { get; set; }
        public virtual DbSet<login_attempts> login_attempts { get; set; }
        public virtual DbSet<lost_clients> lost_clients { get; set; }
        public virtual DbSet<message> messages { get; set; }
        public virtual DbSet<offline_droped> offline_droped { get; set; }
        public virtual DbSet<offline_queue> offline_queue { get; set; }
        public virtual DbSet<ordersm> ordersms { get; set; }
        public virtual DbSet<permission> permissions { get; set; }
        public virtual DbSet<queue_log> queue_log { get; set; }
        public virtual DbSet<queue_status> queue_status { get; set; }
        public virtual DbSet<rest_phones> rest_phones { get; set; }
        public virtual DbSet<restaurant> restaurants { get; set; }
        public virtual DbSet<setting> settings { get; set; }
        public virtual DbSet<settings_sms> settings_sms { get; set; }
        public virtual DbSet<settings_sms_order> settings_sms_order { get; set; }
        public virtual DbSet<sm> sms { get; set; }
        public virtual DbSet<sms_templates> sms_templates { get; set; }
        public virtual DbSet<sr_new_clients> sr_new_clients { get; set; }
        public virtual DbSet<staff> staffs { get; set; }
        public virtual DbSet<stat> stats { get; set; }
        public virtual DbSet<user_phones> user_phones { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<users_groups> users_groups { get; set; }
        public virtual DbSet<users_permissions> users_permissions { get; set; }
        public virtual DbSet<balance> balances { get; set; }
        public virtual DbSet<fo_orderstates> fo_orderstates { get; set; }
        public virtual DbSet<hotline> hotlines { get; set; }
        public virtual DbSet<order> orders { get; set; }
        public virtual DbSet<ordersbk1> ordersbk1 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<balances_settings>()
                .Property(e => e.cell)
                .IsUnicode(false);

            modelBuilder.Entity<balances_settings>()
                .Property(e => e.test)
                .IsUnicode(false);

            modelBuilder.Entity<balances_settings>()
                .Property(e => e.sms_key)
                .IsUnicode(false);

            modelBuilder.Entity<balances_settings>()
                .Property(e => e.desc)
                .IsUnicode(false);

            modelBuilder.Entity<brand>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<c_comments>()
                .Property(e => e.text)
                .IsUnicode(false);

            modelBuilder.Entity<cdr>()
                .Property(e => e.clid)
                .IsUnicode(false);

            modelBuilder.Entity<cdr>()
                .Property(e => e.src)
                .IsUnicode(false);

            modelBuilder.Entity<cdr>()
                .Property(e => e.dst)
                .IsUnicode(false);

            modelBuilder.Entity<cdr>()
                .Property(e => e.dcontext)
                .IsUnicode(false);

            modelBuilder.Entity<cdr>()
                .Property(e => e.channel)
                .IsUnicode(false);

            modelBuilder.Entity<cdr>()
                .Property(e => e.dstchannel)
                .IsUnicode(false);

            modelBuilder.Entity<cdr>()
                .Property(e => e.lastapp)
                .IsUnicode(false);

            modelBuilder.Entity<cdr>()
                .Property(e => e.lastdata)
                .IsUnicode(false);

            modelBuilder.Entity<cdr>()
                .Property(e => e.disposition)
                .IsUnicode(false);

            modelBuilder.Entity<cdr>()
                .Property(e => e.accountcode)
                .IsUnicode(false);

            modelBuilder.Entity<cdr>()
                .Property(e => e.userfield)
                .IsUnicode(false);

            modelBuilder.Entity<cdr>()
                .Property(e => e.uniqueid)
                .IsUnicode(false);

            modelBuilder.Entity<cdr>()
                .Property(e => e.ip)
                .IsUnicode(false);

            modelBuilder.Entity<cdr_offline>()
                .Property(e => e.rest)
                .IsUnicode(false);

            modelBuilder.Entity<cdr_offline>()
                .Property(e => e.src)
                .IsUnicode(false);

            modelBuilder.Entity<cdr_offline>()
                .Property(e => e.dst)
                .IsUnicode(false);

            modelBuilder.Entity<cdr_offline>()
                .Property(e => e.dst_name)
                .IsUnicode(false);

            modelBuilder.Entity<cdr_offline>()
                .Property(e => e._operator)
                .IsUnicode(false);

            modelBuilder.Entity<cdr_offline>()
                .Property(e => e.client_num)
                .IsUnicode(false);

            modelBuilder.Entity<cdr_offline>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<cdr_offline>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<cdr_offline>()
                .Property(e => e.uniqueid)
                .IsUnicode(false);

            modelBuilder.Entity<cdr_real_dst>()
                .Property(e => e.src)
                .IsUnicode(false);

            modelBuilder.Entity<cdr_real_dst>()
                .Property(e => e.dst)
                .IsUnicode(false);

            modelBuilder.Entity<cdr_real_dst>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<cdr_real_dst>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<cdr_real_dst>()
                .Property(e => e.rest_type)
                .IsUnicode(false);

            modelBuilder.Entity<city>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<department>()
                .Property(e => e.dep_name)
                .IsUnicode(false);

            modelBuilder.Entity<dst_codes>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<dst_codes>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<dst_codes>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<dst_groups>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<dst_groups>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<dst_groups>()
                .Property(e => e.rest_type)
                .IsUnicode(false);

            modelBuilder.Entity<dst_groups>()
                .Property(e => e.sms_alfa_name)
                .IsUnicode(false);

            modelBuilder.Entity<fo_orders>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<fo_orders>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<fo_smsbuffer>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<fo_smsbuffer>()
                .Property(e => e.phonenumber)
                .IsUnicode(false);

            modelBuilder.Entity<fo_smsbuffer>()
                .Property(e => e.smstext)
                .IsUnicode(false);

            modelBuilder.Entity<fo_smsbuffer>()
                .Property(e => e.xmltext)
                .IsUnicode(false);

            modelBuilder.Entity<fo_smsbuffer>()
                .Property(e => e.statecode)
                .IsUnicode(false);

            modelBuilder.Entity<fo_smsbuffer>()
                .Property(e => e.reference)
                .IsUnicode(false);

            modelBuilder.Entity<fo_smsbuffer>()
                .Property(e => e.xmlanswer)
                .IsUnicode(false);

            modelBuilder.Entity<fo_smsbystatus>()
                .Property(e => e.smstext)
                .IsUnicode(false);

            modelBuilder.Entity<fo_smsbystatus>()
                .Property(e => e.xmltemplate)
                .IsUnicode(false);

            modelBuilder.Entity<goal>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<group>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<group>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<gsmgateway>()
                .Property(e => e.ip)
                .IsUnicode(false);

            modelBuilder.Entity<login_attempts>()
                .Property(e => e.login)
                .IsUnicode(false);

            modelBuilder.Entity<message>()
                .Property(e => e.message1)
                .IsUnicode(false);

            modelBuilder.Entity<offline_droped>()
                .Property(e => e.dst)
                .IsUnicode(false);

            modelBuilder.Entity<offline_droped>()
                .Property(e => e.unique_id)
                .IsUnicode(false);

            modelBuilder.Entity<offline_queue>()
                .Property(e => e.cdr_id)
                .IsUnicode(false);

            modelBuilder.Entity<offline_queue>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<ordersm>()
                .Property(e => e.smsc)
                .IsUnicode(false);

            modelBuilder.Entity<ordersm>()
                .Property(e => e.sender)
                .IsUnicode(false);

            modelBuilder.Entity<ordersm>()
                .Property(e => e.body)
                .IsUnicode(false);

            modelBuilder.Entity<ordersm>()
                .Property(e => e.pdu)
                .IsUnicode(false);

            modelBuilder.Entity<ordersm>()
                .Property(e => e.ip)
                .IsUnicode(false);

            modelBuilder.Entity<permission>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<permission>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<queue_log>()
                .Property(e => e.time)
                .IsUnicode(false);

            modelBuilder.Entity<queue_log>()
                .Property(e => e.callid)
                .IsUnicode(false);

            modelBuilder.Entity<queue_log>()
                .Property(e => e.queuename)
                .IsUnicode(false);

            modelBuilder.Entity<queue_log>()
                .Property(e => e.agent)
                .IsUnicode(false);

            modelBuilder.Entity<queue_log>()
                .Property(e => e._event)
                .IsUnicode(false);

            modelBuilder.Entity<queue_log>()
                .Property(e => e.data1)
                .IsUnicode(false);

            modelBuilder.Entity<queue_log>()
                .Property(e => e.data2)
                .IsUnicode(false);

            modelBuilder.Entity<queue_log>()
                .Property(e => e.data3)
                .IsUnicode(false);

            modelBuilder.Entity<queue_log>()
                .Property(e => e.data4)
                .IsUnicode(false);

            modelBuilder.Entity<queue_log>()
                .Property(e => e.data5)
                .IsUnicode(false);

            modelBuilder.Entity<queue_log>()
                .Property(e => e.ip)
                .IsUnicode(false);

            modelBuilder.Entity<rest_phones>()
                .Property(e => e.department)
                .IsUnicode(false);

            modelBuilder.Entity<restaurant>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<setting>()
                .Property(e => e.section)
                .IsUnicode(false);

            modelBuilder.Entity<setting>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<setting>()
                .Property(e => e.value)
                .IsUnicode(false);

            modelBuilder.Entity<settings_sms>()
                .Property(e => e.prefix)
                .IsUnicode(false);

            modelBuilder.Entity<settings_sms>()
                .Property(e => e.smsc)
                .IsUnicode(false);

            modelBuilder.Entity<settings_sms>()
                .Property(e => e.cell)
                .IsUnicode(false);

            modelBuilder.Entity<settings_sms_order>()
                .Property(e => e.prefix)
                .IsUnicode(false);

            modelBuilder.Entity<settings_sms_order>()
                .Property(e => e.smsc)
                .IsUnicode(false);

            modelBuilder.Entity<settings_sms_order>()
                .Property(e => e.cell)
                .IsUnicode(false);

            modelBuilder.Entity<sm>()
                .Property(e => e.smsc)
                .IsUnicode(false);

            modelBuilder.Entity<sm>()
                .Property(e => e.sender)
                .IsUnicode(false);

            modelBuilder.Entity<sm>()
                .Property(e => e.body)
                .IsUnicode(false);

            modelBuilder.Entity<sm>()
                .Property(e => e.pdu)
                .IsUnicode(false);

            modelBuilder.Entity<sm>()
                .Property(e => e.ip)
                .IsUnicode(false);

            modelBuilder.Entity<sms_templates>()
                .Property(e => e.template)
                .IsUnicode(false);

            modelBuilder.Entity<staff>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<stat>()
                .Property(e => e.SIP)
                .IsUnicode(false);

            modelBuilder.Entity<stat>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<stat>()
                .Property(e => e.ip)
                .IsUnicode(false);

            modelBuilder.Entity<user_phones>()
                .Property(e => e.department)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.salt)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.activation_code)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.forgotten_password_code)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.remember_code)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.last_name)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.company)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<balance>()
                .Property(e => e.ip)
                .IsUnicode(false);

            modelBuilder.Entity<balance>()
                .Property(e => e.num)
                .IsUnicode(false);

            modelBuilder.Entity<balance>()
                .Property(e => e.text)
                .IsUnicode(false);

            modelBuilder.Entity<fo_orderstates>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<order>()
                .Property(e => e.date)
                .IsUnicode(false);

            modelBuilder.Entity<order>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<order>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<ordersbk1>()
                .Property(e => e.date)
                .IsUnicode(false);

            modelBuilder.Entity<ordersbk1>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<ordersbk1>()
                .Property(e => e.city)
                .IsUnicode(false);
        }
    }
}
