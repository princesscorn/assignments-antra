import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable } from 'rxjs';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})

export class AdminRouteGuard implements CanActivate {
  constructor(private router:Router){}
  canActivate(
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree
    {
        let tmp = localStorage.getItem("token");
        //let tmp = localStorage["token"];
        if (tmp)
        {
          console.log("In AdminRouteGuard " + true);
          return true;
        }
        this.router.navigateByUrl("login");
        return false;
    }
  
}
