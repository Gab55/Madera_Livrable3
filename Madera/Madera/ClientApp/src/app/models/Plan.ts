export class Plan {
    ID?;
    PlancherID: number;
    CoupePrincipaleID: number;
    CouvertureID: number;
    ReferencePlan?: string;
    LibellePlan: string;
    AdressPlan: string;
    CpPlan: number;
    VillePlan: string;
    IdUtilisateurCreation? :number;
    DateCreation :Date;
    IdUtilisateurModification?:number;
    DateModification :Date;
    DateArchivage :Date;
    ListeIdModule: number[];

  }
  