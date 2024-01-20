import { ComponentFixture, TestBed } from '@angular/core/testing';

import { KorisnikRegistracijaComponent } from './korisnik-registracija.component';

describe('KorisnikRegistracijaComponent', () => {
  let component: KorisnikRegistracijaComponent;
  let fixture: ComponentFixture<KorisnikRegistracijaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [KorisnikRegistracijaComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(KorisnikRegistracijaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
