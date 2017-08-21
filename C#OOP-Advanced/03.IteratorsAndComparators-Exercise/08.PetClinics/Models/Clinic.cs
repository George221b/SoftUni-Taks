using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.PetClinics.Models
{
    public class Clinic : IEnumerable<Pet>
    {
        private int roomsCount;
        private Pet[] pets;

        public Clinic(string name, int roomsCount)
        {
            this.RoomsCount = roomsCount;
            this.Name = name;
            this.pets = new Pet[roomsCount];
        }

        public string Name { get; set; }
        public int RoomsCount
        {
            get { return this.roomsCount; }
            set
            {
                if (value % 2 != 1)
                {
                    throw new ArgumentException("Invalid Operation!");
                }

                this.roomsCount = value;
            }
        }

        public bool AddPet(Pet pet)
        {
            int middleRoomIndex = this.pets.Length / 2;
            if (pets[middleRoomIndex] == null)
            {
                pets[middleRoomIndex] = pet;
                return true;
            }

            int count = 1;
            while (this.pets.Any(x => x == null))
            {

                if (this.pets[middleRoomIndex - count] == null)
                {
                    this.pets[middleRoomIndex - count] = pet;
                    return true;
                }
                if (this.pets[middleRoomIndex + count] == null)
                {
                    this.pets[middleRoomIndex + count] = pet;
                    return true;
                }

                count++;
            }

            return false;
        }

        public bool ReleasePet()
        {
            if (this.pets.All(x => x == null))
            {
                return false;
            }

            int middleRoomIndex = this.pets.Length / 2;
            for (int i = middleRoomIndex; i < this.pets.Length; i++)
            {
                if (this.pets[i] != null)
                {
                    this.pets[i] = null;
                    return true;
                }
            }

            for (int i = 0; i < middleRoomIndex; i++)
            {
                if (this.pets[i] != null)
                {
                    this.pets[i] = null;
                    return true;
                }
            }

            return false;
        }

        public bool HasEmptyRooms()
        {
            if (this.pets.Any(x => x == null))
            {
                return true;
            }

            return false;
        }

        public string Print()
        {
            var sb = new StringBuilder();

            foreach (var pet in this.pets)
            {
                if (pet == null)
                {
                    sb.AppendLine("Room empty");
                    continue;
                }
                sb.AppendLine(pet.ToString());
            }

            return sb.ToString().TrimEnd();
        }

        public string Print(int room)
        {
            int roomIndex = room - 1;
            if (roomIndex >= this.pets.Length || roomIndex < 0)
            {
                throw new ArgumentException("Invalid Operation!");
            }
            if (pets[roomIndex] == null)
            {
                return "Room empty";
            }

            return this.pets[roomIndex].ToString();
        }

        public IEnumerator<Pet> GetEnumerator()
        {
            for (int i = 0; i < this.pets.Length; i++)
            {
                yield return this.pets[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
