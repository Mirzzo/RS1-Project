import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';
import { ReactiveFormsModule } from '@angular/forms';
import { Router } from '@angular/router';
import { KorisnikRegistracijaComponent } from './components/korisnik-registracija/korisnik-registracija/korisnik-registracija.component';

@Component({
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule, RouterOutlet],
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  
  /**
   *
   */
  constructor(private router: Router) {}
  
  navigateToKorisnikRegistracija() {
    this.router.navigate(['/korisnik-registracija']);
  }
  title = 'appFrontend';
}
