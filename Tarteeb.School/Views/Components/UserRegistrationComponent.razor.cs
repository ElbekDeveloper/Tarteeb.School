using System;
using Microsoft.AspNetCore.Components;
using Tarteeb.School.Models.UserViews;
using Tarteeb.School.Services.Views.UserViews;
using Tarteeb.School.Views.Bases;
using Component = Tarteeb.School.Models.States;

namespace Tarteeb.School.Views.Components
{
    public partial class UserRegistrationComponent : ComponentBase
    {
        [Inject]
        public IUserViewService UserViewService { get; set; }

        public UserView UserView { get; set; }
        public Component.State CurrentState { get; set; } = Component.State.Content;

        [Parameter]
        public TextBoxBase FirstnameTexboxBase { get; set; }
        public TextBoxBase LastnameTexboxBase { get; set; }
        public TextBoxBase PhoneNumberTexboxBase { get; set; }
        public TextBoxBase EmailTexboxBase { get; set; }
        public DateTimePickerBase BirthDateDateTimePickerBase { get; set; }
        public TextBoxBase PasswordTexboxBase { get; set; }
        public TextBoxBase GitHubUsernameTexboxBase { get; set; }
        public TextBoxBase TelegramUsernameTexboxBase { get; set; }

        protected override void OnInitialized()
        {
            this.UserView = new UserView();
            this.CurrentState = Component.State.Content;
        }

        public async void RegisterUserAsync()
        {
            try
            {
                await this.UserViewService.AddUserAsync(this.UserView);
            }
            catch (Exception exception)
            {
                this.CurrentState = Component.State.Error;
                StateHasChanged();
            }
        }
    }
}