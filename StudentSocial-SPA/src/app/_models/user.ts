import { Photo } from "./photo";

export interface User {
    id: number;
    username: string;
    knownAs: string;
    age: number;
    gender: string;
    created: Date;
    lastActive: Date;
    studentId: string;
    major: string;
    university: string;
    cgpa: number;
    photoUrl: string;
    city: string;
    country: string;
    interests?: string;
    introduction?: string;
    coursesCompleted?: string;
    coursesEnrolled?: string;
    photos?: Photo[];
}
