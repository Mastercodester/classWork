package com.gamblerapi.CasinoDAO;


import com.gamblerapi.model.Casino;

import java.util.ArrayList;
import java.util.List;

public class CasinoMemoryDAO {


    List<Casino> theCasinos;

    public CasinoMemoryDAO(){
        this.theCasinos = new ArrayList<Casino>();
    }

    public List<Casino> getTheCasinos() {
        return theCasinos;
    }
}
