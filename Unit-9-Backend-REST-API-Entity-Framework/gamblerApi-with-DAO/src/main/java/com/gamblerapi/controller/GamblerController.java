package com.gamblerapi.controller;

import com.gamblerapi.dao.GamblerDAO.GamblerMemoryDao;
import com.gamblerapi.model.Gambler;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import java.util.List;

@RestController
public class GamblerController {

private GamblerMemoryDao gamblerDAO;


public GamblerController(){
    this.gamblerDAO = new GamblerMemoryDao();
}


    @GetMapping("/")
    public String methodName(){
        return "Welcome to the Gambler API";
    }


    @GetMapping("/gamblers")
    public List<Gambler> getAllGamblers(){
return gamblerDAO.getGamblers();
    }


    @GetMapping("/gamblers/{id}")
    public Gambler getGamblerById(@PathVariable int id){

    return gamblerDAO.getGamblerbyID(id);
    }

    @GetMapping("/gamblers/search")
    public Gambler getGamblerByName(@RequestParam String name){
    return gamblerDAO.getGamblerName(name);
    }
}
