import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router } from '@angular/router';
import { LoginServiceService } from 'src/app/services/LoginService/login-service.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit, OnDestroy {

  password: string;
  user: string;
  invalidForm: boolean;
  invalidPassForm: boolean;

  constructor(private loginservice : LoginServiceService, private router: Router) {
  
  }

  ngOnInit() {
    this.password= '';
    this.user = '';
    this.invalidForm = false;
    this.invalidPassForm = false;
    
  }
  ngOnDestroy() {
  }

  submit(model, valid){

    if(valid){
      console.log(model)
      this.invalidForm = false;


      this.loginservice.sendLoginData(model).subscribe(
        (res) => {
          
          if(res && res.mensaje == "Bienvenido"){
            this.router.navigate(['#/dashboard']);
            this.invalidPassForm = false;
          }else{
            this.invalidPassForm = true;
          }
        },
        (err) => {
          console.log(err);
        }
      )
    }else{
      console.log("f")
      this.invalidForm = true;
    }
    
  }

}
