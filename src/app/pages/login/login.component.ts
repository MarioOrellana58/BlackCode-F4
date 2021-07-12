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

  constructor(private loginservice : LoginServiceService, private router: Router) {
  
  }

  ngOnInit() {
    this.password= '';
    this.user = '';
    this.invalidForm = false;
    
  }
  ngOnDestroy() {
  }

  submit(model, valid){

    if(valid){
      console.log(model)
      this.invalidForm = false;


      this.loginservice.sendLoginData(model).subscribe(
        (res) => {
          this.router.navigate(['#/dashboard'])
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
