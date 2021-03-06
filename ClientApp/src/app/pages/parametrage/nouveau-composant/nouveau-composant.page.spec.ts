import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { IonicModule } from '@ionic/angular';

import { NouveauComposantPage } from './nouveau-composant.page';

describe('NouveauComposantPage', () => {
  let component: NouveauComposantPage;
  let fixture: ComponentFixture<NouveauComposantPage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ NouveauComposantPage ],
      imports: [IonicModule.forRoot()]
    }).compileComponents();

    fixture = TestBed.createComponent(NouveauComposantPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  }));

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
