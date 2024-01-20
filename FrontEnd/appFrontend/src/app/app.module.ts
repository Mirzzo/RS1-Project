// app.module.ts
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import { KorisnikRegistracijaComponent } from './components/korisnik-registracija/korisnik-registracija/korisnik-registracija.component';
import { AppComponent } from './app.component';
import { RouterModule, Routes } from '@angular/router';
import { BrowserModule } from '@angular/platform-browser';

const routes: Routes = [
  { path: 'korisnik-registracija', component: KorisnikRegistracijaComponent },
];

@NgModule({
  imports: [
      BrowserModule,
      FormsModule,
      ReactiveFormsModule
  ],
  declarations: [
   KorisnikRegistracijaComponent
  ],
})

export class AppModule { }
