import { Component } from '@angular/core';
import { FormBuilder, ReactiveFormsModule, Validators } from '@angular/forms';
import { MaterialModule } from '../../../material.module';
import { RouterLink } from '@angular/router';
import { LoginComponent } from '../login/login.component';
import { userregister } from '../../model/user.model';

@Component({
  selector: 'app-register',
  standalone: true,
  imports: [ReactiveFormsModule, MaterialModule, RouterLink, LoginComponent],
  templateUrl: './register.component.html',
  styleUrl: './register.component.css'
})
export class RegisterComponent {


  constructor(private builder: FormBuilder) {

  }

  _regForm = this.builder.group({

    userName : this.builder.control('', Validators.compose([Validators.required, Validators.minLength(5)])),
    name: this.builder.control('', Validators.required),
    phone : this.builder.control('', Validators.required),
    email : this.builder.control('', Validators.required),
    password : this.builder.control('', Validators.required),
    confirmPassword : this.builder.control('', Validators.required)
  })

  proccedRegister(){

  if(this._regForm.valid){
       let _obj:userregister = {

        userName: this._regForm.value.userName as string,
        name: this._regForm.value.name as string,
        phone: this._regForm.value.phone as string,
        email: this._regForm.value.email as string,
        Password: this._regForm.value.password as string

       }
  }else{
    
  }



  }


}
