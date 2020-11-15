import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { first } from 'rxjs/operators';
import { AuthenticationService } from '../../_services/authentication.service';


@Component({
  selector: 'app-connexion',
  templateUrl: './connexion.page.html',
  styleUrls: ['./connexion.page.scss', './../../app.component.scss'],
})
export class ConnexionPage implements OnInit {
  // loginForm: FormGroup;
  // loading = false;
  // submitted = false;
  // returnUrl: string;
  // error = '';

  constructor(
  //   private formBuilder: FormBuilder,
  //   private route: ActivatedRoute,
  //   private router: Router,
  //   private authenticationService: AuthenticationService

  ) {
  //   if (this.authenticationService.userValue) {
  //     this.router.navigate(['/']);
  //   }
  }

  ngOnInit() {
    // this.loginForm = this.formBuilder.group({
    //   username: ['', Validators.required],
    //   password: ['', Validators.required]
    };

  //   // get return url from route parameters or default to '/'
  //   this.returnUrl = this.route.snapshot.queryParams['returnUrl'] || '/';
  // }

  // // convenience getter for easy access to form fields
  // get f() { return this.loginForm.controls; }

  // onSubmit() {
  //   this.submitted = true;

  //   // stop here if form is invalid
  //   if (this.loginForm.invalid) {
  //     return;
  //   }

  //   this.loading = true;
  //   this.authenticationService.login(this.f.username.value, this.f.password.value)
  //     .pipe(first())
  //     .subscribe({
  //       next: () => {
  //         this.router.navigate([this.returnUrl]);
  //       },
  //       error: error => {
  //         this.error = error;
  //         this.loading = false;
  //       }
  //     });
  // }

}
