using CourseProject.DAL;
using CourseProject.Enums;
using CourseProject.Forms;
using CourseProject.Forms.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject
{
    internal class FormsCreator
    {
        public BaseUserForm GetInstance(Users user)
        {
            switch (user.UserRole)
            {
                case (int)RoleEnum.Пользователь:
                    return new UserForm(user);
                case (int)RoleEnum.Сотрудник:
                    return new EmployeeForm(user);
                case (int)RoleEnum.Администратор:
                    return new AdminForm(user);
                default:
                    throw new Exception("Неопределенная роль");
            }
        }
    }
}
