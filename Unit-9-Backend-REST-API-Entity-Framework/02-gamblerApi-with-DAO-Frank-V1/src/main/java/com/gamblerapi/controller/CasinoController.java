package com.gamblerapi.controller;


import com.gamblerapi.CasinoDAO.CasinoMemoryDAO;
import com.gamblerapi.model.Casino;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

import java.util.List;

@RestController
public class CasinoController {
CasinoMemoryDAO casinoDatasource;


    public CasinoController() {
        this.casinoDatasource = new CasinoMemoryDAO();
    }



    @GetMapping("/casinos")

        public List<Casino> getCasinos(){
            return casinoDatasource.getTheCasinos();
        }

    }

