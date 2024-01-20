import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { MojConfig } from './moj-config';
@Injectable({
  providedIn: 'root'
})
export class UserService {
  private apiUrl = MojConfig.adresa_servera; // Replace with your actual backend API URL

  constructor(private http: HttpClient) { }

  registerUser(userData: any): Observable<any> {
    const headers = new HttpHeaders({ 'Content-Type': 'application/json' });
    
    return this.http.post<any>(`${this.apiUrl}/Registracija`, userData, { headers })
      .pipe(
        catchError(this.handleError)
      );
  }

  // Add other user-related methods as needed, such as login, update profile, etc.

  private handleError(error: any) {
    console.error('API Error:', error);
    return throwError('Something went wrong. Please try again later.'); // Customize error handling based on your requirements
  }
}
