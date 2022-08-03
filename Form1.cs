using System;
using System.Net;
using System.Net.Mail;
using Father.Properties;

namespace Father
{

    

    public partial class Form1 : Form
    {


        string email_body1;
        string email_body2;
           




        public static List<String> amounts = new List<String>();

        public static BindingSource amountsBindingSource = new BindingSource();



        public Form1()
        {
            InitializeComponent();

        }

        private void button_calculations_Click(object sender, EventArgs e)
        {
            calculations form = new calculations();
            form.ShowDialog();
        }

        









        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_database_Click(object sender, EventArgs e)
        {
            amount form_amount = new amount();
            form_amount.ShowDialog();
        }

        private void button_info_Click(object sender, EventArgs e)
        {
            info form_info = new info();
            form_info.ShowDialog();
        }

        private void button_settings_Click(object sender, EventArgs e)
        {
            settings form_settings = new settings();
            form_settings.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email_body = "Dispatched Medicines : ";
            if(calculations.amount_1 > 0)
                email_body += $"\n\n{calculations.amount_1} From ALISERYL";
            if (calculations.amount_2 > 0)
                email_body += $"\n\n{calculations.amount_2} From Albendazole Bolus 600mg";
            if (calculations.amount_3 > 0)
                email_body += $"\n\n{calculations.amount_3} From Albenzole Oral Suspension 10%;LTR";
            if (calculations.amount_4 > 0)
                email_body += $"\n\n{calculations.amount_4} From Ancesol Inj./ANTI-STAMIN;VIAL/100ML";
            if (calculations.amount_5 > 0)
                email_body += $"\n\n{calculations.amount_5} From Antihem / Vitamin k3 Injection;20ml/vial";
            if (calculations.amount_6 > 0)
                email_body += $"\n\n{calculations.amount_6} From Aspivet-C / FIBRINA-C;100g";
            if (calculations.amount_7 > 0)
                email_body += $"\n\n{calculations.amount_7} From Atropine Sulphate;VIAL";
            if (calculations.amount_8 > 0)
                email_body += $"\n\n{calculations.amount_8} From Autoclave Tape Indicator";
            if (calculations.amount_9 > 0)
                email_body += $"\n\n{calculations.amount_9} From Bandage Gauze 36 InchX 100 Yards;Roll";
            if (calculations.amount_10 > 0)
                email_body += $"\n\n{calculations.amount_10} From Bloat Dad 100 ml;BOT";
            if (calculations.amount_11 > 0)
                email_body += $"\n\n{calculations.amount_11} From Buparvon Injection;VIAL/50ML";
            if (calculations.amount_12 > 0)
                email_body += $"\n\n{calculations.amount_12} From CALVING ROPE WITH LOOP(S);PCS";
            if (calculations.amount_13 > 0)
                email_body += $"\n\n{calculations.amount_13} From CCPP Vaccine;DOSE";
            if (calculations.amount_14 > 0)
                email_body += $"\n\n{calculations.amount_14} From Calcium Borogluconate 500ml";
            if (calculations.amount_15 > 0)
                email_body += $"\n\n{calculations.amount_15} From Calfos tonic / VMD-Oligovit Plus Powder";
            if (calculations.amount_16 > 0)
                email_body += $"\n\n{calculations.amount_16} From Ceftiofur  50mg/ml;100ML";
            if (calculations.amount_17 > 0)
                email_body += $"\n\n{calculations.amount_17} From Cetosin lamons / Keto Stop;LTR";
            if (calculations.amount_18 > 0)
                email_body += $"\n\n{calculations.amount_18} From Ciplacin / Sulphacin Bolus 20s;BOX ";
            if (calculations.amount_19 > 0)
                email_body += $"\n\n{calculations.amount_19} From Cloprostenol 250 microgram/ml";
            if (calculations.amount_20 > 0)
                email_body += $"\n\n{calculations.amount_20} From DISP. COVERALLS 2XL;PIC";
            if (calculations.amount_21 > 0)
                email_body += $"\n\n{calculations.amount_21} From DISP. COVERALLS XL;PCS";
            if (calculations.amount_22 > 0)
                email_body += $"\n\n{calculations.amount_22} From DISP. SYRINGE 20ML 50s;BOX";
            if (calculations.amount_23 > 0)
                email_body += $"\n\n{calculations.amount_23} From DOXIN-200 WS / TYLODOX  100G;SACH";
            if (calculations.amount_24 > 0)
                email_body += $"\n\n{calculations.amount_24} From Dexamethasone 2 mg/ 1ml";
            if (calculations.amount_25 > 0)
                email_body += $"\n\n{calculations.amount_25} From Dextrose 5% BP;BOT";
            if (calculations.amount_26 > 0)
                email_body += $"\n\n{calculations.amount_26} From Dextrose 5% in  Normal Saline;500 ML";
            if (calculations.amount_27 > 0)
                email_body += $"\n\n{calculations.amount_27} From Diakur Plus/NUTRIVET PR;SACH";
            if (calculations.amount_28 > 0)
                email_body += $"\n\n{calculations.amount_28} From Disposable Hooded Coverall Waterproof size : 2XL;PIECE";
            if (calculations.amount_29 > 0)
                email_body += $"\n\n{calculations.amount_29} From Disposable Hooded Coverall Waterproof size : XL;PIECE";
            if (calculations.amount_30 > 0)
                email_body += $"\n\n{calculations.amount_30} From Disposable Hypodermic Needles 18GX1/2\";BOX.\"";
            if (calculations.amount_31 > 0)
                email_body += $"\n\n{calculations.amount_31} From Disposable Infusion Set / Sterile;PCS";
            if (calculations.amount_32 > 0)
                email_body += $"\n\n{calculations.amount_32} From Disposable syring 5ML 100/BOX;SYRINGE";
            if (calculations.amount_33 > 0)
                email_body += $"\n\n{calculations.amount_33} From Disposable syring 10 ML";
            if (calculations.amount_34 > 0)
                email_body += $"\n\n{calculations.amount_34} From Doramectin[10 mg /1 ml]";
            if (calculations.amount_35 > 0)
                email_body += $"\n\n{calculations.amount_35} From Duphalyte 500 ML;BOT";
            if (calculations.amount_36 > 0)
                email_body += $"\n\n{calculations.amount_36} From E-Selen Powder;100g/SACS";
            if (calculations.amount_37 > 0)
                email_body += $"\n\n{calculations.amount_37} From Emasco / Vitaminera/Protevit;Bottle";
            if (calculations.amount_38 > 0)
                email_body += $"\n\n{calculations.amount_38} From Enrofloxacin Oral  100MG 1L;Bottle";
            if (calculations.amount_39 > 0)
                email_body += $"\n\n{calculations.amount_39}  From Enzivet Inj.;VIAL";
            if (calculations.amount_40 > 0)                
                email_body += $"\n\n{calculations.amount_40}  From Enzymofarco;Bottle";
            if (calculations.amount_41 > 0)                  
                email_body += $"\n\n{calculations.amount_41}  From FMD vaccine 300ml - 300dose;DOSE";
            if (calculations.amount_42 > 0)              
                email_body += $"\n\n{calculations.amount_42}  From FUROSEMIDE 5% 50ML";
            if (calculations.amount_43 > 0)                 
                email_body += $"\n\n{calculations.amount_43}  From Flogiderm Powder;SACH";
            if (calculations.amount_44 > 0)            
                email_body += $"\n\n{calculations.amount_44}  From Florfenicol Injection;VIAL";
            if (calculations.amount_45 > 0)              
                email_body += $"\n\n{calculations.amount_45}  From Flunixin Meglumine 50mg/ml 100ml";
            if (calculations.amount_46 > 0)               
                email_body += $"\n\n{calculations.amount_46}  From GAUZE BANDAGE 10cm X 6 yds;Roll";
            if (calculations.amount_47 > 0)             
                email_body += $"\n\n{calculations.amount_47}  From GLASS BARREL 50 cc;PCS";
            if (calculations.amount_48 > 0)              
                email_body += $"\n\n{calculations.amount_48}  From GPC8 / Aldekol DES 25 / Agrigerm 1510;GAL";
            if (calculations.amount_49 > 0)               
                email_body += $"\n\n{calculations.amount_49}  From GYPSONA  PLASTER;Roll";
            if (calculations.amount_50 > 0)                
                email_body += $"\n\n{calculations.amount_50}  From Gemicin Spray;BOT/250ML";
            if (calculations.amount_51 > 0)             
                email_body += $"\n\n{calculations.amount_51}  From Herbal Wound Cream;JAR";
            if (calculations.amount_52 > 0)                
                email_body += $"\n\n{calculations.amount_52}  From Hydrogen Peroxide";
            if (calculations.amount_53 > 0)             
                email_body += $"\n\n{calculations.amount_53}  From Hypermineral Plus Solution;Bottle";
            if (calculations.amount_54 > 0)              
                email_body += $"\n\n{calculations.amount_54}  From ICE BOX 36 Liter;PCS";
            if (calculations.amount_55 > 0)                  
                email_body += $"\n\n{calculations.amount_55}  From Imidocarb-LH / IMIZOL;VIAL";
            if (calculations.amount_56 > 0)               
                email_body += $"\n\n{calculations.amount_56}  From Irol Inj. 100ml;VIAL";
            if (calculations.amount_57 > 0)              
                email_body += $"\n\n{calculations.amount_57}  From Ivermectin 10 mg/ml  Vial";
            if (calculations.amount_58 > 0)           
                email_body += $"\n\n{calculations.amount_58}  From Ketoprofen[100 mg / 1 ml]";
            if (calculations.amount_59 > 0)            
                email_body += $"\n\n{calculations.amount_59}  From LONG GLOVES;BOX";
            if (calculations.amount_60 > 0)           
                email_body += $"\n\n{calculations.amount_60}  From Laboratory Eye Wash Solution 1 Piece/Pack";
            if (calculations.amount_61 > 0)           
                email_body += $"\n\n{calculations.amount_61}  From Lidocaine  hydrochloride;VIAL";
            if (calculations.amount_62 > 0)           
                email_body += $"\n\n{calculations.amount_62}  From Liver Tonic Injection;VIAL";
            if (calculations.amount_63 > 0)      
                email_body += $"\n\n{calculations.amount_63}  From MOUTH GAG ( FOR HORSES AND CAMELS );PIECE";
            if (calculations.amount_64 > 0)          
                email_body += $"\n\n{calculations.amount_64}  From Marbofloxacin Inj.10% 100ml";
            if (calculations.amount_65 > 0)         
                email_body += $"\n\n{calculations.amount_65}  From Megamast LC 5g;SYRINGE";
            if (calculations.amount_66 > 0)           
                email_body += $"\n\n{calculations.amount_66}  From Meloxicam 30mg/ml 50ml";
            if (calculations.amount_67 > 0)      
                email_body += $"\n\n{calculations.amount_67}  From Menbutone 100mg/ml Inj. 100ml";
            if (calculations.amount_68 > 0)        
                email_body += $"\n\n{calculations.amount_68}  From Metabol / Cobosal 10 % Vial";
            if (calculations.amount_69 > 0)       
                email_body += $"\n\n{calculations.amount_69}  From NITRILE GLOVES L;BOX";
            if (calculations.amount_70 > 0)     
                email_body += $"\n\n{calculations.amount_70}  From NITRILE GLOVES XL;BOX";
            if (calculations.amount_71 > 0)      
                email_body += $"\n\n{calculations.amount_71}  From NORMAL SALINE;BOT";
            if (calculations.amount_72 > 0)             
                email_body += $"\n\n{calculations.amount_72}  From Novacoc I.V. Infusion";
            if (calculations.amount_73 > 0)      
                email_body += $"\n\n{calculations.amount_73}  From OXYTOCIN . INJ;VIAL";
            if (calculations.amount_74 > 0)             
                email_body += $"\n\n{calculations.amount_74}  From Obstetrical lubricant / Lubrel Gel;500 ML";
            if (calculations.amount_75 > 0)              
                email_body += $"\n\n{calculations.amount_75}  From Orondo Spray 200ml;CAN";
            if (calculations.amount_76 > 0)             
                email_body += $"\n\n{calculations.amount_76}  From Oxytetracycline 200mg/ml  LA inj. 100ml";
            if (calculations.amount_77 > 0)               
                email_body += $"\n\n{calculations.amount_77}  From PARAFFIN OIL 100ML;Bottle";
            if (calculations.amount_78 > 0)               
                email_body += $"\n\n{calculations.amount_78}  From PARTICULATE RESPIRATOR MASKS;BOX";
            if (calculations.amount_79 > 0)              
                email_body += $"\n\n{calculations.amount_79}  From PPR Vaccine;DOSE";
            if (calculations.amount_80 > 0)               
                email_body += $"\n\n{calculations.amount_80}  From Penstrep 400 L.A / Exabiopen;VIAL";
            if (calculations.amount_81 > 0)                
                email_body += $"\n\n{calculations.amount_81}  From Polyglycolic Acid Suture USP 2;PACK";
            if (calculations.amount_82 > 0)              
                email_body += $"\n\n{calculations.amount_82}  From Polyglycolic acid USP 3;PACK";
            if (calculations.amount_83 > 0)                
                email_body += $"\n\n{calculations.amount_83}  From Povidol 10% Solution 500ml";
            if (calculations.amount_84 > 0)                
                email_body += $"\n\n{calculations.amount_84}  From RINGER LACTED;BOT";
            if (calculations.amount_85 > 0)              
                email_body += $"\n\n{calculations.amount_85}  From Roto-Corona Plus / Nutec SPA Calf;SYRINGE";
            if (calculations.amount_86 > 0)              
                email_body += $"\n\n{calculations.amount_86}  From Rumindigest-Antacid / Biogest N;SACS";
            if (calculations.amount_87 > 0)                 
                email_body += $"\n\n{calculations.amount_87}  From STERILE SURGECAL GLOVES 7.5;BOX";
            if (calculations.amount_88 > 0)               
                email_body += $"\n\n{calculations.amount_88}  From STERILE SURGECAL GLOVES 8;BOX";
            if (calculations.amount_89 > 0)                  
                email_body += $"\n\n{calculations.amount_89}  From STERILE SURGICAL BLADE 24 100s";
            if (calculations.amount_90 > 0)              
                email_body += $"\n\n{calculations.amount_90}  From SURGICAL FACE MASK;BOX";
            if (calculations.amount_91 > 0)                
                email_body += $"\n\n{calculations.amount_91}  From Sulphar / Sulprin Ointment;JAR";
            if (calculations.amount_92 > 0)              
                email_body += $"\n\n{calculations.amount_92}  From Surgical Spirit 70%;GAL";
            if (calculations.amount_93 > 0)                
                email_body += $"\n\n{calculations.amount_93}  From Synulox R.T.U Inj. 100ml;VIAL";
            if (calculations.amount_94 > 0)                   
                email_body += $"\n\n{calculations.amount_94}  From Teknosol-B12 Inj. 100ml;VIAL/100ML";
            if (calculations.amount_95 > 0)                 
                email_body += $"\n\n{calculations.amount_95}  From Toxi-clean Oral;Bottle";
            if (calculations.amount_96 > 0)                   
                email_body += $"\n\n{calculations.amount_96}  From Tromexin 500g;500g/jar";
            if (calculations.amount_97 > 0)                   
                email_body += $"\n\n{calculations.amount_97}  From Tropar Forte Inj./ Asipyr-V;VIAL";
            if (calculations.amount_98 > 0)                  
                email_body += $"\n\n{calculations.amount_98}  From Tylosin Plus Inj. 100ml";
            if (calculations.amount_99 > 0)                   
                email_body += $"\n\n{calculations.amount_99}  From UDDERINE OINT. 200G;JAR";
            if (calculations.amount_100 > 0)                  
                email_body += $"\n\n{calculations.amount_100} From Uvevit Plus Inj;VIAL";
            if (calculations.amount_101 > 0)
                email_body += $"\n\n{calculations.amount_101} From VAGINAL Suture TAPE;PCS";
            if (calculations.amount_102 > 0)
                email_body += $"\n\n{calculations.amount_102} From Vitamin-E Selen Inj.;VIAL";
            if (calculations.amount_103 > 0)
                email_body += $"\n\n{calculations.amount_103} From Xylazine Injection 20mg/ml;VIAL";
            if (calculations.amount_104 > 0)
                email_body += $"\n\n{calculations.amount_104} From Zinc Oxide Ointment;JAR";
            if (calculations.amount_105 > 0)
                email_body += $"\n\n{calculations.amount_105} From herbal wound spray;TIN";
            if (calculations.amount_106 > 0)
                email_body += $"\n\n{calculations.amount_106} {{Empty}}";
            if (calculations.amount_107 > 0)
                email_body += $"\n\n{calculations.amount_107} {{Empty}}";
            if (calculations.amount_108 > 0)
                email_body += $"\n\n{calculations.amount_108} {{Empty}}";
            if (calculations.amount_109 > 0)
                email_body += $"\n\n{calculations.amount_109} {{Empty}}";
            if (calculations.amount_110 > 0)
                email_body += $"\n\n{calculations.amount_110} {{Empty}}";
            if (calculations.amount_111 > 0)
                email_body += $"\n\n{calculations.amount_111} {{Empty}}";
            if (calculations.amount_112 > 0)
                email_body += $"\n\n{calculations.amount_112} {{Empty}}";
            if (calculations.amount_113 > 0)
                email_body += $"\n\n{calculations.amount_113} {{Empty}}";
            if (calculations.amount_114 > 0)
                email_body += $"\n\n{calculations.amount_114} {{Empty}}";
            if (calculations.amount_115 > 0)
                email_body += $"\n\n{calculations.amount_115} {{Empty}}";
            if (calculations.amount_116 > 0)
                email_body += $"\n\n{calculations.amount_116} {{Empty}}";
            if (calculations.amount_117 > 0)
                email_body += $"\n\n{calculations.amount_117} {{Empty}}";
            if (calculations.amount_118 > 0)
                email_body += $"\n\n{calculations.amount_118} {{Empty}}";
            if (calculations.amount_119 > 0)
                email_body += $"\n\n{calculations.amount_119} {{Empty}}";
            if (calculations.amount_120 > 0)
                email_body += $"\n\n{calculations.amount_120} {{Empty}}";




            if (settings.SendEmail == true)
            {
                SmtpClient client = new SmtpClient()
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,

                    Credentials = new NetworkCredential()
                    {
                        UserName = "pharmacy.alquaa@gmail.com",
                        Password = "LOL YOU STUPID ??"
                    }
                };
                MailAddress FromEmail = new MailAddress("pharmacy.alquaa@gmail.com", "Medicine Tracker Report");
                MailAddress ToEmail = new MailAddress(settings.email, "Pharmacy Balance Report");
                MailMessage Message = new MailMessage()
                {
                    From = FromEmail,
                    Subject = "Pharmacy Report",
                    Body = email_body,

                };
                Message.To.Add(ToEmail);
                try
                {
                    client.Send(Message);
                    MessageBox.Show("Message Sent successfully", "Done");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something wrong with the connection\n\n" + ex.Message + "Error");
                }
            }
            else
            {

            }
            

        }
        



        public void med_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {

            med_list.Items.Clear();

            if (calculations.amount_1 > 0)
                med_list.Items.Add($"{calculations.amount_1}").SubItems.Add("ALISERYL");
            if (calculations.amount_2 > 0)
                med_list.Items.Add($"{calculations.amount_2}").SubItems.Add("Albendazole Bolus 600mg");
            if (calculations.amount_3 > 0)
                med_list.Items.Add($"{calculations.amount_3}").SubItems.Add("Albenzole Oral Suspension 10%;LTR");
            if (calculations.amount_4 > 0)
                med_list.Items.Add($"{calculations.amount_4}").SubItems.Add("Ancesol Inj./ANTI-STAMIN;VIAL/100ML");
            if (calculations.amount_5 > 0)
                med_list.Items.Add($"{calculations.amount_5}").SubItems.Add("Antihem / Vitamin k3 Injection;20ml/vial");
            if (calculations.amount_6 > 0)
                med_list.Items.Add($"{calculations.amount_6}").SubItems.Add("Aspivet-C / FIBRINA-C;100g");
            if (calculations.amount_7 > 0)
                med_list.Items.Add($"{calculations.amount_7}").SubItems.Add("Atropine Sulphate;VIAL");
            if (calculations.amount_8 > 0)
                med_list.Items.Add($"{calculations.amount_8}").SubItems.Add("Autoclave Tape Indicator");
            if (calculations.amount_9 > 0)
                med_list.Items.Add($"{calculations.amount_9}").SubItems.Add("Bandage Gauze 36 InchX 100 Yards;Roll");
            if (calculations.amount_10 > 0)
                med_list.Items.Add($"{calculations.amount_10}").SubItems.Add("Bloat Dad 100 ml;BOT");
            if (calculations.amount_11 > 0)
                med_list.Items.Add($"{calculations.amount_11}").SubItems.Add("Buparvon Injection;VIAL/50ML");
            if (calculations.amount_12 > 0)
                med_list.Items.Add($"{calculations.amount_12}").SubItems.Add("CALVING ROPE WITH LOOP(S);PCS");
            if (calculations.amount_13 > 0)
                med_list.Items.Add($"{calculations.amount_13}").SubItems.Add("CCPP Vaccine;DOSE");
            if (calculations.amount_14 > 0)
                med_list.Items.Add($"{calculations.amount_14}").SubItems.Add("Calcium Borogluconate 500ml");
            if (calculations.amount_15 > 0)
                med_list.Items.Add($"{calculations.amount_15}").SubItems.Add("Calfos tonic / VMD-Oligovit Plus Powder");
            if (calculations.amount_16 > 0)
                med_list.Items.Add($"{calculations.amount_16}").SubItems.Add("Ceftiofur  50mg/ml;100ML");
            if (calculations.amount_17 > 0)
                med_list.Items.Add($"{calculations.amount_17}").SubItems.Add("Cetosin lamons / Keto Stop;LTR");
            if (calculations.amount_18 > 0)
                med_list.Items.Add($"{calculations.amount_18}").SubItems.Add("Ciplacin / Sulphacin Bolus 20s;BOX");
            if (calculations.amount_19 > 0)
                med_list.Items.Add($"{calculations.amount_19}").SubItems.Add("Cloprostenol 250 microgram/ml");
            if (calculations.amount_20 > 0)
                med_list.Items.Add($"{calculations.amount_20}").SubItems.Add("DISP. COVERALLS 2XL;PIC");
            if (calculations.amount_21 > 0)
                med_list.Items.Add($"{calculations.amount_21}").SubItems.Add("DISP. COVERALLS XL;PCS");
            if (calculations.amount_22 > 0)
                med_list.Items.Add($"{calculations.amount_22}").SubItems.Add("DISP. SYRINGE 20ML 50s;BOX");
            if (calculations.amount_23 > 0)
                med_list.Items.Add($"{calculations.amount_23}").SubItems.Add("DOXIN-200 WS / TYLODOX  100G;SACH");
            if (calculations.amount_24 > 0)
                med_list.Items.Add($"{calculations.amount_24}").SubItems.Add("Dexamethasone 2 mg/ 1ml");
            if (calculations.amount_25 > 0)
                med_list.Items.Add($"{calculations.amount_25}").SubItems.Add("Dextrose 5% BP;BOT");
            if (calculations.amount_26 > 0)
                med_list.Items.Add($"{calculations.amount_26}").SubItems.Add("Dextrose 5% in  Normal Saline;500 ML");
            if (calculations.amount_27 > 0)
                med_list.Items.Add($"{calculations.amount_27}").SubItems.Add("Diakur Plus/NUTRIVET PR;SACH");
            if (calculations.amount_28 > 0)
                med_list.Items.Add($"{calculations.amount_28}").SubItems.Add("Disposable Hooded Coverall Waterproof size : 2XL;PIECE");
            if (calculations.amount_29 > 0)
                med_list.Items.Add($"{calculations.amount_29}").SubItems.Add("Disposable Hooded Coverall Waterproof size : XL;PIECE");
            if (calculations.amount_30 > 0)
                med_list.Items.Add($"{calculations.amount_30}").SubItems.Add("Disposable Hypodermic Needles 18GX1/2\";BOX.\"");
            if (calculations.amount_31 > 0)
                med_list.Items.Add($"{calculations.amount_31}").SubItems.Add("Disposable Infusion Set / Sterile;PCS");
            if (calculations.amount_32 > 0)
                med_list.Items.Add($"{calculations.amount_32}").SubItems.Add("Disposable syring 5ML 100/BOX;SYRINGE");
            if (calculations.amount_33 > 0)
                med_list.Items.Add($"{calculations.amount_33}").SubItems.Add("Disposable syring 10 ML");
            if (calculations.amount_34 > 0)
                med_list.Items.Add($"{calculations.amount_34}").SubItems.Add("Doramectin[10 mg /1 ml]");
            if (calculations.amount_35 > 0)
                med_list.Items.Add($"{calculations.amount_35}").SubItems.Add("Duphalyte 500 ML;BOT");
            if (calculations.amount_36 > 0)
                med_list.Items.Add($"{calculations.amount_36}").SubItems.Add("E-Selen Powder;100g/SACS");
            if (calculations.amount_37 > 0)
                med_list.Items.Add($"{calculations.amount_37}").SubItems.Add("Emasco / Vitaminera/Protevit;Bottle");
            if (calculations.amount_38 > 0)
                med_list.Items.Add($"{calculations.amount_38}").SubItems.Add("Enrofloxacin Oral  100MG 1L;Bottle");
            if (calculations.amount_39 > 0)
                med_list.Items.Add($"{calculations.amount_39}").SubItems.Add("Enzivet Inj.;VIAL");
            if (calculations.amount_40 > 0)
                med_list.Items.Add($"{calculations.amount_40}").SubItems.Add("Enzymofarco;Bottle");
            if (calculations.amount_41 > 0)
                med_list.Items.Add($"{calculations.amount_41}").SubItems.Add("FMD vaccine 300ml - 300dose;DOSE");
            if (calculations.amount_42 > 0)
                med_list.Items.Add($"{calculations.amount_42}").SubItems.Add("FUROSEMIDE 5% 50ML");
            if (calculations.amount_43 > 0)
                med_list.Items.Add($"{calculations.amount_43}").SubItems.Add("Flogiderm Powder;SACH");
            if (calculations.amount_44 > 0)
                med_list.Items.Add($"{calculations.amount_44}").SubItems.Add("Florfenicol Injection;VIAL");
            if (calculations.amount_45 > 0)
                med_list.Items.Add($"{calculations.amount_45}").SubItems.Add("Flunixin Meglumine 50mg/ml 100ml");
            if (calculations.amount_46 > 0)
                med_list.Items.Add($"{calculations.amount_46}").SubItems.Add("GAUZE BANDAGE 10cm X 6 yds;Roll");
            if (calculations.amount_47 > 0)
                med_list.Items.Add($"{calculations.amount_47}").SubItems.Add("GLASS BARREL 50 cc;PCS");
            if (calculations.amount_48 > 0)
                med_list.Items.Add($"{calculations.amount_48}").SubItems.Add("GPC8 / Aldekol DES 25 / Agrigerm 1510;GAL");
            if (calculations.amount_49 > 0)
                med_list.Items.Add($"{calculations.amount_49}").SubItems.Add("GYPSONA  PLASTER;Roll");
            if (calculations.amount_50 > 0)
                med_list.Items.Add($"{calculations.amount_50}").SubItems.Add("Gemicin Spray;BOT/250ML");
            if (calculations.amount_51 > 0)
                med_list.Items.Add($"{calculations.amount_51}").SubItems.Add("Herbal Wound Cream;JAR");
            if (calculations.amount_52 > 0)
                med_list.Items.Add($"{calculations.amount_52}").SubItems.Add("Hydrogen Peroxide");
            if (calculations.amount_53 > 0)
                med_list.Items.Add($"{calculations.amount_53}").SubItems.Add("Hypermineral Plus Solution;Bottle");
            if (calculations.amount_54 > 0)
                med_list.Items.Add($"{calculations.amount_54}").SubItems.Add("ICE BOX 36 Liter;PCS");
            if (calculations.amount_55 > 0)
                med_list.Items.Add($"{calculations.amount_55}").SubItems.Add("Imidocarb-LH / IMIZOL;VIAL");
            if (calculations.amount_56 > 0)
                med_list.Items.Add($"{calculations.amount_56}").SubItems.Add("Irol Inj. 100ml;VIAL");
            if (calculations.amount_57 > 0)
                med_list.Items.Add($"{calculations.amount_57}").SubItems.Add("Ivermectin 10 mg/ml  Vial");
            if (calculations.amount_58 > 0)
                med_list.Items.Add($"{calculations.amount_58}").SubItems.Add("Ketoprofen[100 mg / 1 ml]");
            if (calculations.amount_59 > 0)
                med_list.Items.Add($"{calculations.amount_59}").SubItems.Add("LONG GLOVES;BOX");
            if (calculations.amount_60 > 0)
                med_list.Items.Add($"{calculations.amount_60}").SubItems.Add("Laboratory Eye Wash Solution 1 Piece/Pack");
            if (calculations.amount_61 > 0)
                med_list.Items.Add($"{calculations.amount_61}").SubItems.Add("Lidocaine  hydrochloride;VIAL");
            if (calculations.amount_62 > 0)
                med_list.Items.Add($"{calculations.amount_62}").SubItems.Add("Liver Tonic Injection;VIAL");
            if (calculations.amount_63 > 0)
                med_list.Items.Add($"{calculations.amount_63}").SubItems.Add("MOUTH GAG ( FOR HORSES AND CAMELS );PIECE");
            if (calculations.amount_64 > 0)
                med_list.Items.Add($"{calculations.amount_64}").SubItems.Add("Marbofloxacin Inj.10% 100ml");
            if (calculations.amount_65 > 0)
                med_list.Items.Add($"{calculations.amount_65}").SubItems.Add("Megamast LC 5g;SYRINGE");
            if (calculations.amount_66 > 0)
                med_list.Items.Add($"{calculations.amount_66}").SubItems.Add("Meloxicam 30mg/ml 50ml");
            if (calculations.amount_67 > 0)
                med_list.Items.Add($"{calculations.amount_67}").SubItems.Add("Menbutone 100mg/ml Inj. 100ml");
            if (calculations.amount_68 > 0)
                med_list.Items.Add($"{calculations.amount_68}").SubItems.Add("Metabol / Cobosal 10 % Vial");
            if (calculations.amount_69 > 0)
                med_list.Items.Add($"{calculations.amount_69}").SubItems.Add("NITRILE GLOVES L;BOX");
            if (calculations.amount_70 > 0)
                med_list.Items.Add($"{calculations.amount_70}").SubItems.Add("NITRILE GLOVES XL;BOX");
            if (calculations.amount_71 > 0)
                med_list.Items.Add($"{calculations.amount_71}").SubItems.Add("NORMAL SALINE;BOT");
            if (calculations.amount_72 > 0)
                med_list.Items.Add($"{calculations.amount_72}").SubItems.Add("Novacoc I.V. Infusion");
            if (calculations.amount_73 > 0)
                med_list.Items.Add($"{calculations.amount_73}").SubItems.Add("OXYTOCIN . INJ;VIAL");
            if (calculations.amount_74 > 0)
                med_list.Items.Add($"{calculations.amount_74}").SubItems.Add("Obstetrical lubricant / Lubrel Gel;500 ML");
            if (calculations.amount_75 > 0)
                med_list.Items.Add($"{calculations.amount_75}").SubItems.Add("Orondo Spray 200ml;CAN");
            if (calculations.amount_76 > 0)
                med_list.Items.Add($"{calculations.amount_76}").SubItems.Add("Oxytetracycline 200mg/ml  LA inj. 100ml");
            if (calculations.amount_77 > 0)
                med_list.Items.Add($"{calculations.amount_77}").SubItems.Add("PARAFFIN OIL 100ML;Bottle");
            if (calculations.amount_78 > 0)
                med_list.Items.Add($"{calculations.amount_78}").SubItems.Add("PARTICULATE RESPIRATOR MASKS;BOX");
            if (calculations.amount_79 > 0)
                med_list.Items.Add($"{calculations.amount_79}").SubItems.Add("PPR Vaccine;DOSE");
            if (calculations.amount_80 > 0)
                med_list.Items.Add($"{calculations.amount_80}").SubItems.Add("Penstrep 400 L.A / Exabiopen;VIAL");
            if (calculations.amount_81 > 0)
                med_list.Items.Add($"{calculations.amount_81}").SubItems.Add("Polyglycolic Acid Suture USP 2;PACK");
            if (calculations.amount_82 > 0)
                med_list.Items.Add($"{calculations.amount_82}").SubItems.Add("Polyglycolic acid USP 3;PACK");
            if (calculations.amount_83 > 0)
                med_list.Items.Add($"{calculations.amount_83}").SubItems.Add("Povidol 10% Solution 500ml");
            if (calculations.amount_84 > 0)
                med_list.Items.Add($"{calculations.amount_84}").SubItems.Add("RINGER LACTED;BOT");
            if (calculations.amount_85 > 0)
                med_list.Items.Add($"{calculations.amount_85}").SubItems.Add("Roto-Corona Plus / Nutec SPA Calf;SYRINGE");
            if (calculations.amount_86 > 0)
                med_list.Items.Add($"{calculations.amount_86}").SubItems.Add("Rumindigest-Antacid / Biogest N;SACS");
            if (calculations.amount_87 > 0)
                med_list.Items.Add($"{calculations.amount_87}").SubItems.Add("STERILE SURGECAL GLOVES 7.5;BOX");
            if (calculations.amount_88 > 0)
                med_list.Items.Add($"{calculations.amount_88}").SubItems.Add("STERILE SURGECAL GLOVES 8;BOX");
            if (calculations.amount_89 > 0)
                med_list.Items.Add($"{calculations.amount_89}").SubItems.Add("STERILE SURGICAL BLADE 24 100s");
            if (calculations.amount_90 > 0)
                med_list.Items.Add($"{calculations.amount_90}").SubItems.Add("SURGICAL FACE MASK;BOX");
            if (calculations.amount_91 > 0)
                med_list.Items.Add($"{calculations.amount_91}").SubItems.Add("Sulphar / Sulprin Ointment;JAR");
            if (calculations.amount_92 > 0)
                med_list.Items.Add($"{calculations.amount_92}").SubItems.Add("Surgical Spirit 70%;GAL");
            if (calculations.amount_93 > 0)
                med_list.Items.Add($"{calculations.amount_93}").SubItems.Add("Synulox R.T.U Inj. 100ml;VIAL");
            if (calculations.amount_94 > 0)
                med_list.Items.Add($"{calculations.amount_94}").SubItems.Add("Teknosol-B12 Inj. 100ml;VIAL/100ML");
            if (calculations.amount_95 > 0)
                med_list.Items.Add($"{calculations.amount_95}").SubItems.Add("Toxi-clean Oral;Bottle");
            if (calculations.amount_96 > 0)
                med_list.Items.Add($"{calculations.amount_96}").SubItems.Add("Tromexin 500g;500g/jar");
            if (calculations.amount_97 > 0)
                med_list.Items.Add($"{calculations.amount_97}").SubItems.Add("Tropar Forte Inj./ Asipyr-V;VIAL");
            if (calculations.amount_98 > 0)
                med_list.Items.Add($"{calculations.amount_98}").SubItems.Add("Tylosin Plus Inj. 100ml");
            if (calculations.amount_99 > 0)
                med_list.Items.Add($"{calculations.amount_99}").SubItems.Add("UDDERINE OINT. 200G;JAR");
            if (calculations.amount_100 > 0)
                med_list.Items.Add($"{calculations.amount_100}").SubItems.Add("Uvevit Plus Inj;VIAL");
            if (calculations.amount_101 > 0)
                med_list.Items.Add($"{calculations.amount_101}").SubItems.Add("VAGINAL Suture TAPE;PCS");
            if (calculations.amount_102 > 0)
                med_list.Items.Add($"{calculations.amount_102}").SubItems.Add("Vitamin-E Selen Inj.;VIAL");
            if (calculations.amount_103 > 0)
                med_list.Items.Add($"{calculations.amount_103}").SubItems.Add("Xylazine Injection 20mg/ml;VIAL");
            if (calculations.amount_104 > 0)
                med_list.Items.Add($"{calculations.amount_104}").SubItems.Add("Zinc Oxide Ointment;JAR");
            if (calculations.amount_105 > 0)
                med_list.Items.Add($"{calculations.amount_105}").SubItems.Add("herbal wound spray;TIN");
            if (calculations.amount_106 > 0)
                med_list.Items.Add($"{calculations.amount_106}").SubItems.Add("{Empty}");
            if (calculations.amount_107 > 0)
                med_list.Items.Add($"{calculations.amount_107}").SubItems.Add("{Empty}");
            if (calculations.amount_108 > 0)
                med_list.Items.Add($"{calculations.amount_108}").SubItems.Add("{Empty}");
            if (calculations.amount_109 > 0)
                med_list.Items.Add($"{calculations.amount_109}").SubItems.Add("{Empty}");
            if (calculations.amount_110 > 0)
                med_list.Items.Add($"{calculations.amount_110}").SubItems.Add("{Empty}");
            if (calculations.amount_111 > 0)
                med_list.Items.Add($"{calculations.amount_111}").SubItems.Add("{Empty}");
            if (calculations.amount_112 > 0)
                med_list.Items.Add($"{calculations.amount_112}").SubItems.Add("{Empty}");
            if (calculations.amount_113 > 0)
                med_list.Items.Add($"{calculations.amount_113}").SubItems.Add("{Empty}");
            if (calculations.amount_114 > 0)
                med_list.Items.Add($"{calculations.amount_114}").SubItems.Add("{Empty}");
            if (calculations.amount_115 > 0)
                med_list.Items.Add($"{calculations.amount_115}").SubItems.Add("{Empty}");
            if (calculations.amount_116 > 0)
                med_list.Items.Add($"{calculations.amount_116}").SubItems.Add("{Empty}");
            if (calculations.amount_117 > 0)
                med_list.Items.Add($"{calculations.amount_117}").SubItems.Add("{Empty}");
            if (calculations.amount_118 > 0)
                med_list.Items.Add($"{calculations.amount_118}").SubItems.Add("{Empty}");
            if (calculations.amount_119 > 0)
                med_list.Items.Add($"{calculations.amount_119}").SubItems.Add("{Empty}");
            if (calculations.amount_120 > 0)
                med_list.Items.Add($"{calculations.amount_120}").SubItems.Add("{Empty}");

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            calculations.amount_1 = 0;
            calculations.amount_2 = 0;
            calculations.amount_3 = 0;
            calculations.amount_4 = 0;
            calculations.amount_5 = 0;
            calculations.amount_6 = 0;
            calculations.amount_7 = 0;
            calculations.amount_8 = 0;
            calculations.amount_9 = 0;
            calculations.amount_10 = 0;
            calculations.amount_11 = 0;
            calculations.amount_12 = 0;
            calculations.amount_13 = 0;
            calculations.amount_14 = 0;
            calculations.amount_15 = 0;
            calculations.amount_16 = 0;
            calculations.amount_17 = 0;
            calculations.amount_18 = 0;
            calculations.amount_19 = 0;
            calculations.amount_20 = 0;
            calculations.amount_21 = 0;
            calculations.amount_22 = 0;
            calculations.amount_23 = 0;
            calculations.amount_24 = 0;
            calculations.amount_25 = 0;
            calculations.amount_26 = 0;
            calculations.amount_27 = 0;
            calculations.amount_28 = 0;
            calculations.amount_29 = 0;
            calculations.amount_30 = 0;
            calculations.amount_31 = 0;
            calculations.amount_32 = 0;
            calculations.amount_33 = 0;
            calculations.amount_34 = 0;
            calculations.amount_35 = 0;
            calculations.amount_36 = 0;
            calculations.amount_37 = 0;
            calculations.amount_38 = 0;
            calculations.amount_39 = 0;
            calculations.amount_40 = 0;
            calculations.amount_41 = 0;
            calculations.amount_42 = 0;
            calculations.amount_43 = 0;
            calculations.amount_44 = 0;
            calculations.amount_45 = 0;
            calculations.amount_46 = 0;
            calculations.amount_47 = 0;
            calculations.amount_48 = 0;
            calculations.amount_49 = 0;
            calculations.amount_50 = 0;
            calculations.amount_51 = 0;
            calculations.amount_52 = 0;
            calculations.amount_53 = 0;
            calculations.amount_54 = 0;
            calculations.amount_55 = 0;
            calculations.amount_56 = 0;
            calculations.amount_57 = 0;
            calculations.amount_58 = 0;
            calculations.amount_59 = 0;
            calculations.amount_60 = 0;
            calculations.amount_61 = 0;
            calculations.amount_62 = 0;
            calculations.amount_63 = 0;
            calculations.amount_64 = 0;
            calculations.amount_65 = 0;
            calculations.amount_66 = 0;
            calculations.amount_67 = 0;
            calculations.amount_68 = 0;
            calculations.amount_69 = 0;
            calculations.amount_70 = 0;
            calculations.amount_71 = 0;
            calculations.amount_72 = 0;
            calculations.amount_73 = 0;
            calculations.amount_74 = 0;
            calculations.amount_75 = 0;
            calculations.amount_76 = 0;
            calculations.amount_77 = 0;
            calculations.amount_78 = 0;
            calculations.amount_79 = 0;
            calculations.amount_80 = 0;
            calculations.amount_81 = 0;
            calculations.amount_82 = 0;
            calculations.amount_83 = 0;
            calculations.amount_84 = 0;
            calculations.amount_85 = 0;
            calculations.amount_86 = 0;
            calculations.amount_87 = 0;
            calculations.amount_88 = 0;
            calculations.amount_89 = 0;
            calculations.amount_90 = 0;
            calculations.amount_91 = 0;
            calculations.amount_92 = 0;
            calculations.amount_93 = 0;
            calculations.amount_94 = 0;
            calculations.amount_95 = 0;
            calculations.amount_96 = 0;
            calculations.amount_97 = 0;
            calculations.amount_98 = 0;
            calculations.amount_99 = 0;
            calculations.amount_100 = 0;
            calculations.amount_101 = 0;
            calculations.amount_102 = 0;
            calculations.amount_103 = 0;
            calculations.amount_104 = 0;
            calculations.amount_105 = 0;
            calculations.amount_106 = 0;
            calculations.amount_107 = 0;
            calculations.amount_108 = 0;
            calculations.amount_109 = 0;
            calculations.amount_110 = 0;
            calculations.amount_111 = 0;
            calculations.amount_112 = 0;
            calculations.amount_113 = 0;
            calculations.amount_114 = 0;
            calculations.amount_115 = 0;
            calculations.amount_116 = 0;
            calculations.amount_117 = 0;
            calculations.amount_118 = 0;
            calculations.amount_119 = 0;
            calculations.amount_120 = 0;
        }
    }
}
