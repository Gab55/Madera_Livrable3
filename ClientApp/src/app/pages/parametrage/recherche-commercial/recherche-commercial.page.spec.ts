import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { IonicModule } from '@ionic/angular';

import { RechercheCommercialPage } from './recherche-commercial.page';

describe('RechercheCommercialPage', () => {
  let component: RechercheCommercialPage;
  let fixture: ComponentFixture<RechercheCommercialPage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RechercheCommercialPage ],
      imports: [IonicModule.forRoot()]
    }).compileComponents();

    fixture = TestBed.createComponent(RechercheCommercialPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  }));

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
