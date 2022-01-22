using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace ImageFromToDatabase
{
    public class SanadDataClass
    {
        //all columns need to be shown on report should be here as a member variable
        //with particular datatype if you want crystal report functions available to operate on your data
        //like number values should be int or decimal
        //date columns should be datetime 

        public int Exam_Data_ID { get; set; }
        public int Form_No { get; set; }
        public int Link_Roll_Number { get; set; }

        public byte[] Picture_File { get; set; }

        public Image PictureImage { get; set; }

        public string Candidate_Name { get; set; }
        public string Date_Of_Birth { get; set; }
        public string Bay_Form_Number { get; set; }
        public string Father_Name { get; set; }
        public string Father_CNIC { get; set; }

        public int Gender { get; set; }
        public int Religion { get; set; }
        public int Nationality { get; set; }
        public int Specialty { get; set; }
        public bool Is_Hafiz { get; set; }
        public int District_Code { get; set; }
        public int Tehsil_Code { get; set; }

        public string Post_Address { get; set; }
        public string Landline { get; set; }
        public string FGMobileNo { get; set; }
        public string E_Mail { get; set; }

        public int Zone_Code { get; set; }
        public int Exam_Type { get; set; }
        public int Group_Code { get; set; }

        public string Comp_Subjects_P1 { get; set; }
        public string Elec_Subjects_P1 { get; set; }
        public string Comp_Subjects_P2 { get; set; }
        public string Elec_Subjects_P2 { get; set; }

        public int Medium { get; set; }
        public int Student_Type { get; set; }
        public int Roll_Number { get; set; }
        public int SSC_Board_ID { get; set; }
        public int SSC_Roll_Number { get; set; }
        public int SSC_Passing_Year { get; set; }
        public int SSC_Session { get; set; }
        public int Bank_ID { get; set; }
        public int Branch_Code { get; set; }

        public string Challan_No { get; set; }
        public string Date_Submitted { get; set; }

        public int Amount { get; set; }

        public string Registration_Number { get; set; }
        public string Identification_Mark { get; set; }

        public int Passing_Year { get; set; }
        public int Part { get; set; }
        public int Session { get; set; }
        public int Next_Roll_Number { get; set; }
        public int Next_Passing_Year { get; set; }
        public int Next_Board_ID { get; set; }
        public int Next_Session { get; set; }

        public string Next_Result_Notification { get; set; }

        // ........................................................Subject 1 Start.....................................................
        public int Paper11_Code { get; set; }
        public string Paper11_Marks { get; set; }
        public int Paper11_Status { get; set; }
        public string op11 { get; set; }

        public int Paper21_Code { get; set; }
        public string Paper21_Marks { get; set; }
        public int Paper21_Status { get; set; }
        public string op21 { get; set; }
        public string Subject1_Name { get; set; }


        public string Subject1_TotalMarks { get; set; }
        public string Subject1_ObtailedMarks { get; set; }
        public int Subject1_Status { get; set; }

    // ........................................................Subject 1 End.....................................................

        public int Paper12_Code { get; set; }
        public string Paper12_Marks { get; set; }
        public int Paper12_Status { get; set; }
        public string op12 { get; set; }

        public int Paper22_Code { get; set; }
        public string Paper22_Marks { get; set; }
        public int Paper22_Status { get; set; }
        public string op22 { get; set; }
        public string Subject2_Name { get; set; }


        public string Subject2_TotalMarks { get; set; }
        public string Subject2_ObtailedMarks { get; set; }
        public int Subject2_Status { get; set; }


        // ........................................................Subject 2 End.....................................................

        public int Paper13_Code { get; set; }
        public string Paper13_Marks { get; set; }
        public int Paper13_Status { get; set; }
        public string op13 { get; set; }

        public int Paper23_Code { get; set; }
        public string Paper23_Marks { get; set; }
        public int Paper23_Status { get; set; }
        public string op23 { get; set; }
        public string Subject3_Name { get; set; }


        public string Subject3_TotalMarks { get; set; }
        public string Subject3_ObtailedMarks { get; set; }
        public int Subject3_Status { get; set; }

        // ........................................................Subject 3 End.....................................................

        public int Paper14_Code { get; set; }
        public string Paper14_Marks { get; set; }
        public int Paper14_Status { get; set; }
        public string op14 { get; set; }

        public int Paper24_Code { get; set; }
        public string Paper24_Marks { get; set; }
        public int Paper24_Status { get; set; }
        public string op24 { get; set; }
        public string Subject4_Name { get; set; }


        public string Subject4_TotalMarks { get; set; }
        public string Subject4_ObtailedMarks { get; set; }
        public int Subject4_Status { get; set; }

        // ........................................................Subject 4 End.....................................................

        public int Paper15_Code { get; set; }
        public string Paper15_Marks { get; set; }
        public int Paper15_Status { get; set; }
        public string op15 { get; set; }

        public int Paper25_Code { get; set; }
        public string Paper25_Marks { get; set; }
        public int Paper25_Status { get; set; }

        public string Practical15_Marks { get; set; }
        public string Practical25_Marks { get; set; }


        public string op25 { get; set; }
        public string Subject5_Name { get; set; }


        public string Subject5_TotalMarks { get; set; }
        public string Subject5_ObtailedMarks { get; set; }
        public int Subject5_Status { get; set; }

        // ........................................................Subject 5 End.....................................................

        public int Paper16_Code { get; set; }
        public string Paper16_Marks { get; set; }
        public int Paper16_Status { get; set; }
        public string op16 { get; set; }

        public int Paper26_Code { get; set; }
        public string Paper26_Marks { get; set; }
        public int Paper26_Status { get; set; }

        public string Practical16_Marks { get; set; }
        public string Practical26_Marks { get; set; }


        public string op26 { get; set; }
        public string Subject6_Name { get; set; }


        public string Subject6_TotalMarks { get; set; }
        public string Subject6_ObtailedMarks { get; set; }
        public int Subject6_Status { get; set; }

        // ........................................................Subject 6 End.....................................................


        public int Paper17_Code { get; set; }
        public string Paper17_Marks { get; set; }
        public int Paper17_Status { get; set; }
        public string op17 { get; set; }

        public int Paper27_Code { get; set; }
        public string Paper27_Marks { get; set; }
        public int Paper27_Status { get; set; }

        public string Practical17_Marks { get; set; }
        public string Practical27_Marks { get; set; }


        public string op27 { get; set; }
        public string Subject7_Name { get; set; }


        public string Subject7_TotalMarks { get; set; }
        public string Subject7_ObtailedMarks { get; set; }
        public int Subject7_Status { get; set; }

        // ........................................................Subject 7 End.....................................................

        public int Paper18_Code { get; set; }
        public string Paper18_Marks { get; set; }
        public int Paper18_Status { get; set; }
        public string op18 { get; set; }

        public int Paper28_Code { get; set; }
        public string Paper28_Marks { get; set; }
        public int Paper28_Status { get; set; }

        public string Practical18_Marks { get; set; }
        public string Practical28_Marks { get; set; }


        public string op28 { get; set; }
        public string Subject8_Name { get; set; }


        public string Subject8_TotalMarks { get; set; }
        public string Subject8_ObtailedMarks { get; set; }
        public int Subject8_Status { get; set; }

        // ........................................................Subject 8 End.....................................................

        public int Marks_Obtained { get; set; }
        public int Marks_Total { get; set; }
        public int Overall_Status { get; set; }

        public string Result_Notification { get; set; }

        public int Chances_Left { get; set; }

        public string Created_By { get; set; }
        
        public int Institution_Code { get; set; }
        public int FC_Code { get; set; }

        public string Date_Created { get; set; }
        public string Time_Created { get; set; }
        public string Updated_By { get; set; }
        public string Date_Updated { get; set; }
        public string Time_Updated { get; set; }

        public int Center { get; set; }

        public string Shift { get; set; }

        public int Allocation_ID { get; set; }
        public int Previous_Board_ID { get; set; }
        public int Previous_Passing_Year { get; set; }
        public int Previous_SESSION { get; set; }
        public int Previous_ROll_No { get; set; }

        public string Previous_Notification { get; set; }

        public bool B2B_NOC { get; set; }
        
        public int NOC_Board_ID { get; set; }
        public int First_Previous_Board_ID { get; set; }
        public int First_Previous_Passing_Year { get; set; }
        public int First_Previous_SESSION { get; set; }
        public int First_Previous_ROll_No { get; set; }

        public string First_Previous_Notification { get; set; }
        public string InstitueteName { get; set; }
        public string ExamHeld { get; set; }
        public string ResultDate { get; set; }
        public string Grade_Obtained { get; set; }
        public string Internal_Grade { get; set; }
        public string Internal_Grade_String { get; set; }
        public string Exam_Session { get; set; }
        public string DateOfBirthEnglish { get; set; }
        public string PassedIn { get; set; }
        public string ExamGroup { get; set; }

        public string GenderHeShe { get; set; }
        public string GenderHimHer { get; set; }
        public string GenderSonDaughter { get; set; }

        public string MarksImproved { get; set; }

        public string Subject1_ABBR { get; set; }
        public string Subject2_ABBR { get; set; }
        public string Subject3_ABBR { get; set; }
        public string Subject4_ABBR { get; set; }
        public string Subject5_ABBR { get; set; }
        public string Subject6_ABBR { get; set; }
        public string Subject7_ABBR { get; set; }
        public string Subject8_ABBR { get; set; }

        public string SelectedPath { get; set; }
        public string ExamSessionPassingYear { get; set; }
        public string Certificate_Sr_No { get; set; }
        public string ResultTable { get; set; }


      

    }
}
