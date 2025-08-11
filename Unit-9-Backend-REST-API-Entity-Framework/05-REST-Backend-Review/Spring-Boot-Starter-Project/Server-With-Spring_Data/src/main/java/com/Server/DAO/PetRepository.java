package com.Server.DAO;

import com.Server.Model.Pet;
import org.springframework.data.jpa.repository.JpaRepository;


public interface PetRepository extends JpaRepository<Pet, Integer>{



}
