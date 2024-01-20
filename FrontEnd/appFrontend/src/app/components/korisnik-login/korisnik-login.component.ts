import { Component, OnInit } from '@angular/core';
import {AuthLoginRequest} from "./authLoginRequest";
import {MojConfig} from "../../moj-config";
import {HttpClient} from "@angular/common/http";
import {AuthLoginResponse} from "./authLoginResponse";
import {Router} from "@angular/router";
import {MyAuthService} from "../../services/MyAuthService";

@Component({
  selector: 'app-korisnik-login',
  templateUrl: './korisnik-login.component.html',
  styleUrls: ['./korisnik-login.component.css']
})
export class Sedmica7LoginComponent implements OnInit {

  public loginRequest: AuthLoginRequest = {
    lozinka:"",
    korisnickoIme:"",
    signalRubConnectionID:""
  };
  constructor(
    public httpClient:HttpClient,
    private router: Router,
    private myAuthService:MyAuthService
  ) { }

  ngOnInit(): void {
  }

  signIn() {
    let url=MojConfig.adresa_servera+`/auth/login`;
    this.myAuthService.signIn(this.loginRequest)
      .subscribe(x=>{
      if (!x.isLogiran){
        alert("pogresan username/pass")
      }
      else{
      alert("uspjesno ste se logirali")
      }
    })
  }
}
