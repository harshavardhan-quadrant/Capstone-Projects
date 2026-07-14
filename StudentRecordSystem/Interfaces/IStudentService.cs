namespace StudentRecordSystem.Interfaces
{
    public interface IStudentService
    {
        void AddStudent();
        void ViewStudents();
        void SearchStudent();
        void UpdateStudent();
        void DeleteStudent();
        void SortStudents();
        void ShowTopper();
        void DepartmentWiseStudents();
    }
}