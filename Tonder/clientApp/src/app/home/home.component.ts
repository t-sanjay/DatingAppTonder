import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  registerMode = false;
  loginMode = false;
  constructor() { }

  ngOnInit(): void {

  }
  registerToggle() {
    this.registerMode = !this.registerMode;
  }
  

  loginToggle() {
    this.loginMode = !this.loginMode;
  }
  cancelRegister(event: boolean) {
    this.registerMode = event;
  }
  cancelLogin(event: boolean) {
    this.loginMode = event;
  }

  
}
