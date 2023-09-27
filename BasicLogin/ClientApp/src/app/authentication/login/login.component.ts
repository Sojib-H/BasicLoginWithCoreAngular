import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Login } from '../../Models/Login';
import { LoginService } from '../../services/login.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  login: Login = new Login();
  constructor(private loginService: LoginService, private router: Router) { }
  ngOnInit(): void { }

  validation() {

  }

  NewLogin() {
    this.loginService.login(this.login).subscribe((data) => {
      if (data.MsgCode == "OK") {
        this.router.navigate(['/view/dashboard']); 
      }
    })
  }

}
