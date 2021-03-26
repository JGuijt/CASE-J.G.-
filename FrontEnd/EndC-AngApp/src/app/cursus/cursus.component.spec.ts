import { ComponentFixture, TestBed } from '@angular/core/testing';
import { CursusComponent } from './cursus.component';
import { HttpClientTestingModule } from '@angular/common/http/testing';
describe('CursusComponent', () => {
  let component: CursusComponent;
  let fixture: ComponentFixture<CursusComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CursusComponent ],
      imports: [HttpClientTestingModule]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CursusComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });


});



