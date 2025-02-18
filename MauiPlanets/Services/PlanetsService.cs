using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiPlanets.Models;

namespace MauiPlanets.Services
{
    class PlanetsService
    {

        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Mercury",
                Subtitle = "The smallest planet",
                HeroImage = "mercury.png",
                Description = "Mercury is the first planet from the Sun and the smallest in the Solar System. In English, it is named after the ancient Roman god Mercurius (Mercury), god of commerce and communication, and the messenger of the gods. Mercury is classified as a terrestrial planet, with roughly the same surface gravity as Mars. The surface of Mercury is heavily cratered, as a result of countless impact events that have accumulated over billions of years.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4a/Mercury_in_true_color.jpg/435px-Mercury_in_true_color.jpg",
                    "https://www.universetoday.com/wp-content/uploads/2012/03/mercury_internal.jpg"
                }
            },
            new()
            {
                Name = "Venus",
                Subtitle = "The pressure cooker",
                HeroImage = "venus.png",
                Description = "Venus is the second planet from the Sun. It is a terrestrial planet and is the closest in mass and size to its orbital neighbour Earth. Venus has by far the densest atmosphere of the terrestrial planets, composed mostly of carbon dioxide with a thick, global sulfuric acid cloud cover. At the surface it has a mean temperature of 737 K (464 °C; 867 °F) and a pressure 92 times that of Earth's at sea level. These extreme conditions compress carbon dioxide into a supercritical state at Venus's surface.",
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#d17f21"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b2/Venus_2_Approach_Image.jpg/435px-Venus_2_Approach_Image.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/6/60/PIA00103_Venus_-_3-D_Perspective_View_of_Lavinia_Planitia.jpg/330px-PIA00103_Venus_-_3-D_Perspective_View_of_Lavinia_Planitia.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e8/InteriorOfVenus.svg/330px-InteriorOfVenus.svg.png",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/5/54/Venus_-_December_23_2016.png/330px-Venus_-_December_23_2016.png"
                }
            },
            new()
            {
                Name = "Earth",
                Subtitle = "The cradle of life",
                HeroImage = "earth.png",
                Description = "Earth is the third planet from the Sun and the only astronomical object known to harbor life. This is enabled by Earth being an ocean world, the only one in the Solar System sustaining liquid surface water. Almost all of Earth's water is contained in its global ocean, covering 70.8% of Earth's crust. The remaining 29.2% of Earth's crust is land, most of which is located in the form of continental landmasses within Earth's land hemisphere. Most of Earth's land is at least somewhat humid and covered by vegetation, while large sheets of ice at Earth's polar deserts retain more water than Earth's groundwater, lakes, rivers, and atmospheric water combined.",
                AccentColorStart = Color.FromArgb("#0e3d68"),
                AccentColorEnd = Color.FromArgb("#2e97c7"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/6/69/Earth2014shape_SouthAmerica_small.jpg/435px-Earth2014shape_SouthAmerica_small.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/9/97/The_Earth_seen_from_Apollo_17.jpg/435px-The_Earth_seen_from_Apollo_17.jpg",
                    "https://images.newscientist.com/wp-content/uploads/2019/09/09162708/iss048-e-2035_lrg.jpg?width=778"
                }
            },
            new()
            {
                Name = "Mars",
                Subtitle = "The red beauty",
                HeroImage = "mars.png",
                Description = "Mars is the fourth planet from the Sun. The surface of Mars is orange-red because it is covered in iron(III) oxide dust, giving it the nickname the Red Planet. Mars is among the brightest objects in Earth's sky, and its high-contrast albedo features have made it a common subject for telescope viewing. It is classified as a terrestrial planet and is the second smallest of the Solar System's planets with a diameter of 6,779 km (4,212 mi). In terms of orbital motion, a Martian solar day (sol) is equal to 24.6 hours, and a Martian solar year is equal to 1.88 Earth years (687 Earth days).",
                AccentColorStart = Color.FromArgb("#a23036"),
                AccentColorEnd = Color.FromArgb("#eb3333"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0c/Mars_-_August_30_2021_-_Flickr_-_Kevin_M._Gill.png/435px-Mars_-_August_30_2021_-_Flickr_-_Kevin_M._Gill.png",
                    "https://www.worldatlas.com/r/w1300-q80/upload/bb/c3/32/shutterstock-1041249343.jpg",
                    "https://www.openaccessgovernment.org/wp-content/uploads/2021/04/dreamstime_xxl_121672573-scaled.jpg"
                }
            },
            new()
            {
                Name = "Jupiter",
                Subtitle = "The gas giant",
                HeroImage = "jupiter.png",
                Description = "Jupiter is the fifth planet from the Sun and the largest in the Solar System. It is a gas giant with a mass more than 2.5 times that of all the other planets in the Solar System combined and slightly less than one-thousandth the mass of the Sun. Its diameter is eleven times that of Earth, and a tenth that of the Sun. Jupiter orbits the Sun at a distance of 5.20 AU (778.5 Gm), with an orbital period of 11.86 years.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2b/Jupiter_and_its_shrunken_Great_Red_Spot.jpg/435px-Jupiter_and_its_shrunken_Great_Red_Spot.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b1/Jupiter_size.png/330px-Jupiter_size.png",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a3/790106-0203_Voyager_58M_to_31M_reduced.gif/330px-790106-0203_Voyager_58M_to_31M_reduced.gif"
                }
            },
            new()
            {
                Name = "Saturn",
                Subtitle = "The ring planet",
                HeroImage = "saturn.png",
                Description = "Saturn is the sixth planet from the Sun and the second largest in the Solar System, after Jupiter. It is a gas giant, with an average radius of about nine times that of Earth. It has an eighth the average density of Earth, but is over 95 times more massive. Even though Saturn is almost as big as Jupiter, Saturn has less than a third its mass. Saturn orbits the Sun at a distance of 9.59 AU (1,434 million km), with an orbital period of 29.45 years. ",
                AccentColorStart = Color.FromArgb("#996237"),
                AccentColorEnd = Color.FromArgb("#c6502f"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c7/Saturn_during_Equinox.jpg/450px-Saturn_during_Equinox.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e1/Saturn_compared_to_Earth_and_the_Moon.png/330px-Saturn_compared_to_Earth_and_the_Moon.png",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2d/Saturn_diagram.svg/495px-Saturn_diagram.svg.png",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/2/29/Saturn_Storm.jpg/330px-Saturn_Storm.jpg"
                }
            },
            new()
            {
                Name = "Uranus",
                Subtitle = "The Herschel planet",
                HeroImage = "uranus.png",
                Description = "Uranus is the seventh planet from the Sun. It is a gaseous cyan-coloured ice giant. Most of the planet is made of water, ammonia, and methane in a supercritical phase of matter, which astronomy calls \"ice\" or volatiles. The planet's atmosphere has a complex layered cloud structure and has the lowest minimum temperature (49 K (−224 °C; −371 °F)) of all the Solar System's planets. It has a marked axial tilt of 82.23° with a retrograde rotation period of 17 hours and 14 minutes. This means that in an 84-Earth-year orbital period around the Sun, its poles get around 42 years of continuous sunlight, followed by 42 years of continuous darkness.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#996237"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/6/69/Uranus_Voyager2_color_calibrated.png",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/9/95/Uranus%2C_Earth_size_comparison_2.jpg/330px-Uranus%2C_Earth_size_comparison_2.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6d/Uranus_diagram.svg/675px-Uranus_diagram.svg.png"
                }
            },
            new()
            {
                Name = "Neptune",
                Subtitle = "The god of the sea",
                HeroImage = "neptune.png",
                Description = "Neptune is the eighth and farthest known planet from the Sun. It is the fourth-largest planet in the Solar System by diameter, the third-most-massive planet, and the densest giant planet. It is 17 times the mass of Earth. Compared to its fellow ice giant Uranus, Neptune is slightly more massive, but denser and smaller. Being composed primarily of gases and liquids, it has no well-defined solid surface, and orbits the Sun once every 164.8 years at an orbital distance of 30.1 astronomical units (4.5 billion kilometres; 2.8 billion miles). It is named after the Roman god of the sea and has the astronomical symbol ♆, representing Neptune's trident.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b9/Neptune_Voyager2_color_calibrated.png/435px-Neptune_Voyager2_color_calibrated.png",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2f/Neptune%2C_Earth_size_comparison_true_color.jpg/330px-Neptune%2C_Earth_size_comparison_true_color.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a7/Another_Neptune_diagram.svg/495px-Another_Neptune_diagram.svg.png"
                }
            },
            new()
            {
                Name = "Pluto",
                Subtitle = "The previous planet",
                HeroImage = "pluto.png",
                Description = "Pluto is a dwarf planet in the Kuiper belt, a ring of bodies beyond the orbit of Neptune. It is the ninth-largest and tenth-most-massive known object to directly orbit the Sun. It is the largest known trans-Neptunian object by volume, by a small margin, but is less massive than Eris. Like other Kuiper belt objects, Pluto is made primarily of ice and rock and is much smaller than the inner planets. Pluto has roughly one-sixth the mass of the Moon, and one-third its volume.",
                AccentColorStart = Color.FromArgb("#bcb8b5"),
                AccentColorEnd = Color.FromArgb("#563f35"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ef/Pluto_in_True_Color_-_High-Res.jpg/435px-Pluto_in_True_Color_-_High-Res.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/7/72/Pluto_rotation_movie2.gif",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/2/23/Pluto%E2%80%99s_Heart_-_Like_a_Cosmic_Lava_Lamp.jpg/330px-Pluto%E2%80%99s_Heart_-_Like_a_Cosmic_Lava_Lamp.jpg"
                }
            },
            new()
            {
                Name = "Ceres",
                Subtitle = "The asteroid belt dwarf planet",
                HeroImage = "ceres.png",
                Description = "Ceres is a dwarf planet in the middle main asteroid belt between the orbits of Mars and Jupiter. It was the first known asteroid, discovered on 1 January 1801 by Giuseppe Piazzi at Palermo Astronomical Observatory in Sicily, and announced as a new planet. Ceres was later classified as an asteroid and then a dwarf planet, the only one not beyond Neptune's orbit.",
                AccentColorStart = Color.FromArgb("#bababa"),
                AccentColorEnd = Color.FromArgb("#555356"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/7/76/Ceres_-_RC3_-_Haulani_Crater_%2822381131691%29_%28cropped%29.jpg/435px-Ceres_-_RC3_-_Haulani_Crater_%2822381131691%29_%28cropped%29.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/8/86/The_Four_Largest_Asteroids.jpg/450px-The_Four_Largest_Asteroids.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/2/22/PIA20348_crop_-_Ceres%27_Ahuna_Mons_top_view.jpg/315px-PIA20348_crop_-_Ceres%27_Ahuna_Mons_top_view.jpg"
                }
            },
            new()
            {
                Name = "Haumea",
                Subtitle = "The quickly spinning dwarf planet",
                HeroImage = "haumea.png",
                Description = "Haumea is a dwarf planet located beyond Neptune's orbit. It was discovered in 2004 by a team headed by Mike Brown of Caltech at the Palomar Observatory, and formally announced in 2005 by a team headed by José Luis Ortiz Moreno at the Sierra Nevada Observatory in Spain, who had discovered it that year in precovery images taken by the team in 2003. From that announcement, it received the provisional designation 2003 EL61.",
                AccentColorStart = Color.FromArgb("#aaa098"),
                AccentColorEnd = Color.FromArgb("#595247"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9c/Haumea_Rotation.gif/320px-Haumea_Rotation.gif",
                    "https://i.guim.co.uk/img/media/8ba455b0fcc4943d263e08ba334c7dfaba690991/163_652_3543_2126/master/3543.jpg?width=1200&height=1200&quality=85&auto=format&fit=crop&s=afd8e15c143dbb88db21179301109a80",
                    "https://i0.wp.com/spacenews.com/wp-content/uploads/2022/10/Screen-Shot-2022-10-18-at-6.38.28-PM.png?resize=864%2C672&ssl=1"
                }
            },
            new()
            {
                Name = "MakeMake",
                Subtitle = "The extremely cold dwarf planet",
                HeroImage = "makemake.png",
                Description = "Makemake is a dwarf planet and the largest of what is known as the classical population of Kuiper belt objects, with a diameter approximately that of Saturn's moon Iapetus, or 60% that of Pluto. It has one known satellite. Its extremely low average temperature, about 40 K (−230 °C), means its surface is covered with methane, ethane, and possibly nitrogen ices. Makemake shows signs of geothermal activity and thus may be capable of supporting active geology and harboring an active subsurface ocean.",
                AccentColorStart = Color.FromArgb("#a97761"),
                AccentColorEnd = Color.FromArgb("#85412c"),
                Images = new()
                {
                    "https://astronz.nz/cdn/shop/articles/makemake.png?v=1682129134",
                    "https://science.nasa.gov/wp-content/uploads/2023/04/makemakemoon100mile-jpg.webp?w=2000",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSic9AFGvdm2ZrdlMuhiq0V9PxsvDMxntTE_g&s"
                }
            },
            new()
            {
                Name = "Eris",
                Subtitle = "The heaviest dwarf planet",
                HeroImage = "eris.png",
                Description = "Eris is the most massive and second-largest known dwarf planet in the Solar System. It is a trans-Neptunian object (TNO) in the scattered disk and has a high-eccentricity orbit. Eris was discovered in January 2005 by a Palomar Observatory–based team led by Mike Brown and verified later that year. It was named in September 2006 after the Greco–Roman goddess of strife and discord. Eris is the ninth-most massive known object orbiting the Sun and the sixteenth-most massive overall in the Solar System (counting moons).",
                AccentColorStart = Color.FromArgb("#b3a497"),
                AccentColorEnd = Color.FromArgb("#a08b77"),
                Images = new()
                {
                    "https://i.natgeofe.com/n/495a21cb-c570-43d8-b5f7-3dfbedb91932/42531.jpg",
                    "https://static.wikia.nocookie.net/space/images/8/84/Eris_New.jpg/revision/latest?cb=20231219172138",
                    "https://starchild.gsfc.nasa.gov/Images/StarChild/solar_system_level2/eris_and_dysnomia_485.jpg"
                }
            },
        };

        public static List<Planet> GetFeaturedPlanets()
        {
            var random = new Random();
            var randomizePlanets = planets
                .OrderBy(item => random.Next());

            return randomizePlanets
                .Take(2)
                .ToList();
        }

        public static List<Planet> GetAllPlanets()
            => planets;
    }
}
