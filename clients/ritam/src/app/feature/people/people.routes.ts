import { Routes } from "@angular/router";
import { PeopleComponent } from "./components/people/people.component";

export const peopleRoutes: Routes = [
    { path: '', loadComponent: () => PeopleComponent }
]