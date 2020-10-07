import { NgModule } from '@angular/core';
import { PreloadAllModules, RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: 'connexion',
    loadChildren: () => import('./pages/connexion/connexion.module').then(m => m.ConnexionPageModule)
  },
  {
    path: '',
    redirectTo: 'connexion',
    pathMatch: 'full'
  },
  {
    path: 'menu-principal',
    loadChildren: () => import('./pages/menu-principal/menu-principal.module').then( m => m.MenuPrincipalPageModule)
  },
  {
    path: 'menu-admin',
    loadChildren: () => import('./pages/menu-admin/menu-admin.module').then( m => m.MenuAdminPageModule)
  },
  {
    path: 'clients',
    loadChildren: () => import('./pages/clients/clients.module').then( m => m.CLientsPageModule)
  },
  {
    path: 'gestion-projet',
    loadChildren: () => import('./pages/gestion-projet/gestion-projet.module').then( m => m.GestionProjetPageModule)
  },
  {
    path: 'gestion-plan',
    loadChildren: () => import('./pages/gestion-plan/gestion-plan.module').then( m => m.GestionPlanPageModule)
  },
  {
    path: 'gestion-devis',
    loadChildren: () => import('./pages/gestion-devis/gestion-devis.module').then( m => m.GestionDevisPageModule)
  },
  {
    path: 'gestion-modelisation',
    loadChildren: () => import('./pages/gestion-modelisation/gestion-modelisation.module').then( m => m.GestionModelisationPageModule)
  },
  {
    path: 'header',
    loadChildren: () => import('./pages/header/header.module').then( m => m.HeaderPageModule)
  },
  {
    path: 'footer',
    loadChildren: () => import('./pages/footer/footer.module').then( m => m.FooterPageModule)
  },
  {
    path: 'header-menu',
    loadChildren: () => import('./pages/header-menu/header-menu.module').then( m => m.HeaderMenuPageModule)
  },
  {
    path: 'recherche-projet',
    loadChildren: () => import('./pages/recherche-projet/recherche-projet.module').then( m => m.RechercheProjetPageModule)
  },
  {
    path: 'nouveau-projet',
    loadChildren: () => import('./pages/nouveau-projet/nouveau-projet.module').then( m => m.NouveauProjetPageModule)
  },
  {
    path: 'recherche-devis',
    loadChildren: () => import('./pages/recherche-devis/recherche-devis.module').then( m => m.RechercheDevisPageModule)
  },
  {
    path: 'recherche-client',
    loadChildren: () => import('./pages/recherche-client/recherche-client.module').then( m => m.RechercheClientPageModule)
  },
  {
    path: 'nouveau-client',
    loadChildren: () => import('./pages/nouveau-client/nouveau-client.module').then( m => m.NouveauClientPageModule)
  },
  {
    path: 'parametrage',
    loadChildren: () => import('./pages/parametrage/parametrage.module').then( m => m.ParametragePageModule)
  },  {
    path: 'recherche-module',
    loadChildren: () => import('./pages/recherche-module/recherche-module.module').then( m => m.RechercheModulePageModule)
  },
  {
    path: 'recherche-gamme',
    loadChildren: () => import('./pages/recherche-gamme/recherche-gamme.module').then( m => m.RechercheGammePageModule)
  },
  {
    path: 'recherche-famille-composant',
    loadChildren: () => import('./pages/recherche-famille-composant/recherche-famille-composant.module').then( m => m.RechercheFamilleComposantPageModule)
  },
  {
    path: 'recherche-composant',
    loadChildren: () => import('./pages/recherche-composant/recherche-composant.module').then( m => m.RechercheComposantPageModule)
  },
  {
    path: 'recherche-commercial',
    loadChildren: () => import('./pages/recherche-commercial/recherche-commercial.module').then( m => m.RechercheCommercialPageModule)
  },
  {
    path: 'nouveau-commercial',
    loadChildren: () => import('./pages/nouveau-commercial/nouveau-commercial.module').then( m => m.NouveauCommercialPageModule)
  },
  {
    path: 'nouveau-composant',
    loadChildren: () => import('./pages/nouveau-composant/nouveau-composant.module').then( m => m.NouveauComposantPageModule)
  },
  {
    path: 'nouveau-module',
    loadChildren: () => import('./pages/nouveau-module/nouveau-module.module').then( m => m.NouveauModulePageModule)
  },
  {
    path: 'nouvelle-gamme',
    loadChildren: () => import('./pages/nouvelle-gamme/nouvelle-gamme.module').then( m => m.NouvelleGammePageModule)
  },
  {
    path: 'nouvelle-famille-composant',
    loadChildren: () => import('./pages/nouvelle-famille-composant/nouvelle-famille-composant.module').then( m => m.NouvelleFamilleComposantPageModule)
  }

];

@NgModule({
  imports: [
    RouterModule.forRoot(routes, { preloadingStrategy: PreloadAllModules })
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
