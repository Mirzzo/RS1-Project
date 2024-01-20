import { FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { UserService } from '../../../UserService';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-korisnik-registracija',
  templateUrl: './korisnik-registracija.component.html',
  styleUrls: ['./korisnik-registracija.component.css'] // Use 'styleUrls' instead of 'styleUrl'
})
export class KorisnikRegistracijaComponent implements OnInit {
  registrationForm: FormGroup;

  constructor(private fb: FormBuilder, private userService: UserService) {
    this.registrationForm = this.fb.group({
      username: ['', [Validators.required]],
      email: ['', [Validators.required, Validators.email]],
      password: ['', [Validators.required, Validators.minLength(8)]],
    });
  }

  ngOnInit(): void {
    // Initialization logic, if needed
  }

  get formControls() {
    return this.registrationForm.controls;
  }

  onSubmit() {
    if (this.registrationForm.valid) {
      const userData = this.registrationForm.value;

      // Call the user service to register the user
      this.userService.registerUser(userData).subscribe(
        response => {
          // Handle successful registration
          console.log('User registered successfully', response);
        },
        error => {
          // Handle registration error
          console.error('Registration error', error);
        }
      );
    }
  }
}
