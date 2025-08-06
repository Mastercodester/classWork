package com.gamblerapi.model;

public class Casino {

private String casinoName;
private String location;
private String Owner;
private int Size;

    public Casino(String casinoName, String location, String owner, int size) {
        this.casinoName = casinoName;
        this.location = location;
        this.Owner = owner;
        this.Size = size;
    }


    public String getCasinoName() {
        return casinoName;
    }

    public void setCasinoName(String casinoName) {
        this.casinoName = casinoName;
    }

    public String getLocation() {
        return location;
    }

    public void setLocation(String location) {
        this.location = location;
    }

    public int getSize() {
        return Size;
    }

    public void setSize(int size) {
        Size = size;
    }

    public String getOwner() {
        return Owner;
    }

    public void setOwner(String owner) {
        Owner = owner;
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
        return super.toString();
    }
}
