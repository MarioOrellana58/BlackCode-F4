import { Component, OnInit, OnDestroy } from '@angular/core';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit, OnDestroy {

  password: string;
  user: string;

  constructor() {}

  ngOnInit() {
    this.password= '';
    this.user = '';
  }
  ngOnDestroy() {
  }

  submit(model, valid){

    if(valid){
      console.log(model)
    }else{
      console.log("f")
    }
    
  }

}
