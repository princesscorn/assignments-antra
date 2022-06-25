import { DecimalPipe } from "@angular/common";

export interface MovieModel {
    id: number;
    title: string;
    overview: string;
    tagline: string;
    budget: number,
    revenue: number,
    imdbUrl: string,
    tmdbUrl: string,
    posterUrl: string,
    backdropUrl: string,
    originalLanguage: string,
    releaseDate: Date,
    runTime: number,
    price: number,
    createdDate: Date,
    updatedDate: Date,
    updatedBy: string,
    createdBy: string
}