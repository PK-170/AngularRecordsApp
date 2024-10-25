import { Path } from './../../node_modules/@angular/compiler-cli/node_modules/readdirp/index.d';
import { Routes } from '@angular/router';
import { HomeComponent } from './component/home/home.component';
import { RegisterComponent } from './component/register/register.component';
import { LoginComponent } from './component/login/login.component';
import { ConfirmotpComponent } from './component/confirmotp/confirmotp.component';

export const routes: Routes = [
  {path:'', component:RegisterComponent},
  {path:'register', component:RegisterComponent},
  {path:'login', component:LoginComponent},
  {path:'confirmotp', component:ConfirmotpComponent}

];
