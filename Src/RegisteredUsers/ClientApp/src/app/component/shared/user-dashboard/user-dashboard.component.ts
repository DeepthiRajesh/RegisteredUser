import { Component, OnInit } from '@angular/core';
import { UserService } from '../../../service/web-request/user.service';
import { RegistrationModel } from '../../../models/common/registration.model';

@Component({
    selector: 'app-user-dashboard',
    templateUrl: './user-dashboard.component.html',
    styleUrls: ['./user-dashboard.component.css']
})
export class UserDashboardComponent implements OnInit {
    public data: Array<RegistrationModel>;
    
    constructor(private userService: UserService) {
        this.data = new Array<RegistrationModel>();
        
    }

    ngOnInit() {
        
        this.getData(1);
    }
    public getData(userId:number): void {
        this.userService.getUserDetails(userId)
            .subscribe(datas => {
                this.data.push(datas);
                console.log(this.data);
            }, error => console.error(error));
    }
}
