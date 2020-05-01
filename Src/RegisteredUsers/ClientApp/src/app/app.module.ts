import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { DashboardComponent } from './component/admin/dashboard/dashboard.component';
import { LoginComponent } from './component/shared/login/login.component';
import { RegistrationComponent } from './component/shared/registration/registration.component';
import { NavMenuComponent } from './component/shared/nav-menu/nav-menu.component';
import { HomeComponent } from './component/user/home/home.component';
import { UserDashboardComponent } from './component/shared/user-dashboard/user-dashboard.component';



@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        HomeComponent,
        RegistrationComponent,
        LoginComponent,
        DashboardComponent,
        UserDashboardComponent
    ],
    imports: [
        BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
        HttpClientModule,
        FormsModule,
        RouterModule.forRoot([
            { path: '', component: HomeComponent, pathMatch: 'full' },
            { path: 'registration', component: RegistrationComponent },
            { path: 'login', component: LoginComponent },
            { path: 'dashboard', component: DashboardComponent },
            { path: 'userDashbord', component: UserDashboardComponent },
        ])
    ],
    providers: [],
    bootstrap: [AppComponent]
})
export class AppModule { }
