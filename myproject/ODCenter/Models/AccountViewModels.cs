﻿using System;
using System.ComponentModel.DataAnnotations;

namespace ODCenter.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "电子邮件")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string Action { get; set; }
        public string ReturnUrl { get; set; }
    }

    public class ManageUserViewModel
    {
        [Required, DataType(DataType.Password), Display(Name = "当前密码")]
        public string OldPassword { get; set; }

        [Required, DataType(DataType.Password), Display(Name = "新密码")]
        [StringLength(100, ErrorMessage = "{0} 必须至少包含 {2} 个字符。", MinimumLength = 6)]
        public string NewPassword { get; set; }

        [DataType(DataType.Password), Display(Name = "确认新密码")]
        [Compare("NewPassword", ErrorMessage = "新密码和确认密码不匹配。")]
        public string ConfirmPassword { get; set; }
    }

    public class ManageUserInfoModel
    {
        [Required, Display(Name = "名"), StringLength(20)]
        public String FirstName { get; set; }

        [Required, Display(Name = "姓"), StringLength(20)]
        public String LastName { get; set; }

        [Display(Name = "昵称"), StringLength(50)]
        public String NickName { get; set; }

        [Required, Display(Name = "单位"), StringLength(50)]
        public String Company { get; set; }

        [Required, Display(Name = "部门"), StringLength(50)]
        public String Department { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "电子邮件")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "密码")]
        public string Password { get; set; }

        [Display(Name = "记住我?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required, EmailAddress, Display(Name = "电子邮件")]
        public string Email { get; set; }

        [Required, Display(Name = "名"), StringLength(20)]
        public String FirstName { get; set; }

        [Required, Display(Name = "姓"), StringLength(20)]
        public String LastName { get; set; }

        [Display(Name = "昵称"), StringLength(50)]
        public String NickName { get; set; }

        [Required, Display(Name = "单位"), StringLength(50)]
        public String Company { get; set; }

        [Required, Display(Name = "部门"), StringLength(50)]
        public String Department { get; set; }

        [Required, DataType(DataType.Password), Display(Name = "密码")]
        [StringLength(100, ErrorMessage = "{0} 必须至少包含 {2} 个字符。", MinimumLength = 6)]
        public String Password { get; set; }

        [DataType(DataType.Password), Display(Name = "确认密码")]
        [Compare("Password", ErrorMessage = "密码和确认密码不匹配。")]
        public String ConfirmPassword { get; set; }

        [Display(Name = "授权码")]
        public String InviteCode { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required, EmailAddress, Display(Name = "电子邮件")]
        public string Email { get; set; }

        [Required, DataType(DataType.Password), Display(Name = "密码")]
        [StringLength(100, ErrorMessage = "{0} 必须至少包含 {2} 个字符。", MinimumLength = 6)]
        public string Password { get; set; }

        [DataType(DataType.Password), Display(Name = "确认密码")]
        [Compare("Password", ErrorMessage = "密码和确认密码不匹配。")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required, EmailAddress, Display(Name = "电子邮件")]
        public string Email { get; set; }
    }
}
