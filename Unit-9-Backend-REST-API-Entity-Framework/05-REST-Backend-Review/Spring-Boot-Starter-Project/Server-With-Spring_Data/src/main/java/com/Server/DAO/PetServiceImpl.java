package com.Server.DAO;

import com.Server.Model.Pet;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;


@Service
public class PetServiceImpl implements IPet {


    PetRepository thePetRepository;

   @Autowired
    public PetServiceImpl(PetRepository thePetRepository) {
        this.thePetRepository = thePetRepository;
    }

    @Override
    public List<Pet> getAllPets() {
        return thePetRepository.findAll();
    }

    @Override
    public Optional<Pet> returnPet(int pkey) {
        return thePetRepository.findById(pkey);
    }

    @Override
    public Pet addPet(Pet aPet) {
        return thePetRepository.save(aPet);
    }

    @Override
    public Pet updatePe(Pet aPet) {
        return thePetRepository.save(aPet);
    }

    @Override
    public void deletePet(int priKey) {




       thePetRepository.deleteById(priKey);
    }
}
