import { VehicleFormComponent } from './vehicle-form/vehicle-form.component';
import { NgModule } from "@angular/core";
import { Routes,RouterModule } from "@angular/router";

const appRouts: Routes = [
    { path: '', component: VehicleFormComponent },
    { path: 'vehicles/new', component: VehicleFormComponent }
];

@NgModule({
    imports: [RouterModule.forRoot(appRouts)],
    exports: [RouterModule]
})
export class AppRoutingModule{

}