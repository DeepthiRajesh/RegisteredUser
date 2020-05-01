import { Component, OnInit } from '@angular/core';
import { RegistrationModel } from '../../../models/common/registration.model';
import { UserService } from '../../../service/web-request/user.service';

@Component({
    selector: 'app-dashboard',
    templateUrl: './dashboard.component.html',
    styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {

    public data: Array<RegistrationModel>;
    
    constructor(private userService: UserService) {
        this.data = new Array<RegistrationModel>();
       
    }

    ngOnInit() {
        this.getData(1);
    }

    public getData(userId: number): void {
        this.userService.getUserDetails(userId)
            .subscribe(datas => {
                this.data.push(datas);
                console.log(this.data);
            }, error => console.error(error));
    }
}

