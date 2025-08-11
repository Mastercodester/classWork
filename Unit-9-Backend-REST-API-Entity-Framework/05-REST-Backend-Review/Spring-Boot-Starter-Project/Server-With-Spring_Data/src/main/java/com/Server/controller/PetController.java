package com.Server.controller;


import com.Server.DAO.PetServiceImpl;
import com.Server.Model.Pet;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/v1")
public class PetController {

    PetServiceImpl ThePetService;


    public PetController(PetServiceImpl thePetService) {
        ThePetService = thePetService;
    }







    @GetMapping("/pets")
    public List<Pet> getPets(){
        return ThePetService.getAllPets();
    }

    @PostMapping("/pets")
    public Pet  addaPet(@RequestBody Pet newPet){
        return ThePetService.addPet(newPet);
    }
}
