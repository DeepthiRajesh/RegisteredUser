import { Component, OnInit } from '@angular/core';
import { LoginModel } from '../../../models/common/login.model';
import { UserService } from '../../../service/web-request/user.service';
import { Router } from '@angular/router';
import { HttpResponse, HttpErrorResponse } from '@angular/common/http';

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

    public validationMessage: string;

    public login: LoginModel

    constructor(private userService: UserService,
        private router: Router) {
        this.validationMessage = '';
        this.login = new LoginModel();
    }

    ngOnInit() {
    }

    public submit(): void {

        this.validationMessage = '';

        this.userService.login(this.login)
            .subscribe(
                (response: HttpResponse<any>) => {
                    if (response.ok) {
                        //localStorage.setItem("jwt", token);
                        this.router.navigate(['dashboard']);
                    }
                    console.log(response.body);
                },
                (error: HttpErrorResponse) => {
                    if (error.status === 400) {
                        this.validationMessage = error.error;
                    }
                    console.log(error);
                }
            );
    }
}
