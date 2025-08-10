package com.Server.Model;


import jakarta.persistence.*;



import java.util.Objects;

import static jakarta.persistence.GenerationType.IDENTITY;

@Entity
@Table(name = "pet")
public class Pet {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)

    @Column(name="pet_id")
    private int PetId;

    @Column(name="name")
    private String petName;

    @Column(name="pet_type_id")
    private int petTypeId;

    @Column(name="owner_id")
    private int ownerId;


    public Pet(){

    }


    public Pet(int petId, String petName, int petTypeId, int ownerId) {



        PetId = petId;
        this.petName = petName;
        this.petTypeId = petTypeId;
        this.ownerId = ownerId;
    }


    public int getPetId() {
        return PetId;
    }

    public void setPetId(int petId) {
        PetId = petId;
    }

    public String getPetName() {
        return petName;
    }

    public void setPetName(String petName) {
        this.petName = petName;
    }

    public int getPetTypeId() {
        return petTypeId;
    }

    public void setPetTypeId(int petTypeId) {
        this.petTypeId = petTypeId;
    }

    public int getOwnerId() {
        return ownerId;
    }

    public void setOwnerId(int ownerId) {
        this.ownerId = ownerId;
    }


    @Override
    public int hashCode() {
        return super.hashCode();
    }

    @Override
    public boolean equals(Object obj) {
        return super.equals(obj);
    }

    @Override
    public String toString() {
        return "Pet{" +
                "PetId=" + PetId +
                ", petName='" + petName + '\'' +
                ", petTypeId=" + petTypeId +
                ", ownerId=" + ownerId +
                '}';
    }
}
