import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";

import { AppComponent } from "./app.component";

import { AngularFireModule } from "@angular/fire";
import { AngularFireDatabaseModule } from "@angular/fire/database";

import { FormsModule, ReactiveFormsModule } from "@angular/forms";

import { environment } from "../environments/environment";
import { EditComponent } from "./cadastros/edit/edit.component";
import { ListComponent } from "./cadastros/list/list.component";

@NgModule({
  declarations: [AppComponent, ListComponent, EditComponent],
  imports: [
    BrowserModule,
    ReactiveFormsModule,
    FormsModule,
    AngularFireModule.initializeApp(environment.firebaseConfig),
    AngularFireDatabaseModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {}
