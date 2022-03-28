import { Component, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { CookieService } from 'ngx-cookie-service';
import { ServiceService } from '../Shared/service.service';
import { Login } from '../Shared/_Login';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  loginRequest: Login = new Login();
  roles: any[] = [];

  constructor(private service: ServiceService, private router: Router, 
   private cookies: CookieService) { }

  ngOnInit(): void {
  }
  onSubmit(){
    this.service.Login(this.loginRequest).subscribe(
      res => {
          this.cookies.set('access_token',res.token);
          this.cookies.set('User',res.user);
          window.location.replace("http://localhost:5025/#/Home/aboutus");
        },
        error=>{
          alert("Incorrect Credentials")
        }
    );
  }
}
