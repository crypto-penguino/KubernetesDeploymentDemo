﻿// <auto-generated />
using System;
using CustomerService.Api.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CustomerService.Api.Migrations
{
    [DbContext(typeof(CustomerDbContext))]
    [Migration("20210131094106_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("CustomerService.Api.Database.Models.CustomerDto", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("Gender")
                        .HasColumnType("text");

                    b.Property<Guid>("Guid")
                        .HasColumnType("uuid");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedTime")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Email = "jsibley0@wp.com",
                            FirstName = "Justis",
                            Gender = "Bigender",
                            Guid = new Guid("24183b3d-196e-4695-887b-606d72ab042a"),
                            LastName = "Sibley",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2L,
                            Email = "nhubbart1@amazon.co.uk",
                            FirstName = "Nev",
                            Gender = "Male",
                            Guid = new Guid("7401a43e-46a4-4d3e-9f2c-a53f4fa546ca"),
                            LastName = "Hubbart",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3L,
                            Email = "rsteynor2@washingtonpost.com",
                            FirstName = "Richardo",
                            Gender = "Female",
                            Guid = new Guid("f47d70a5-92d9-4e40-92ab-901625f08091"),
                            LastName = "Steynor",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4L,
                            Email = "gdeeprose3@studiopress.com",
                            FirstName = "Guenevere",
                            Gender = "Female",
                            Guid = new Guid("66e8fa52-f015-474c-9342-549347ffe69a"),
                            LastName = "Deeprose",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5L,
                            Email = "wallonby4@fotki.com",
                            FirstName = "Wynn",
                            Gender = "Male",
                            Guid = new Guid("5e586b3b-7ffc-4e39-bb41-0dca659e54cf"),
                            LastName = "Allonby",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6L,
                            Email = "abrede5@timesonline.co.uk",
                            FirstName = "Andre",
                            Gender = "Non-binary",
                            Guid = new Guid("92b6d64b-1335-4bb7-a58e-c0d4fecf0260"),
                            LastName = "Brede",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7L,
                            Email = "wmccotter6@bravesites.com",
                            FirstName = "Willdon",
                            Gender = "Bigender",
                            Guid = new Guid("b0312cfc-b42f-43fd-a9c2-59e2caafb02a"),
                            LastName = "McCotter",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8L,
                            Email = "mraymond7@howstuffworks.com",
                            FirstName = "Madlin",
                            Gender = "Male",
                            Guid = new Guid("4422eed3-c90d-4726-a20c-64fc2ca6a049"),
                            LastName = "Raymond",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 9L,
                            Email = "gespino8@ycombinator.com",
                            FirstName = "Garwin",
                            Gender = "Male",
                            Guid = new Guid("6a65484e-dc0c-4956-89d3-9b9104006974"),
                            LastName = "Espino",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 10L,
                            Email = "hstennes9@chicagotribune.com",
                            FirstName = "Hieronymus",
                            Gender = "Non-binary",
                            Guid = new Guid("7a566d8c-c64a-49d7-a107-25a1f6fa3668"),
                            LastName = "Stennes",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 11L,
                            Email = "lmcgarrya@mtv.com",
                            FirstName = "Lacie",
                            Gender = "Female",
                            Guid = new Guid("4f76c895-e9b0-4036-b0f7-24ea07aff553"),
                            LastName = "McGarry",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 12L,
                            Email = "rstembridgeb@webs.com",
                            FirstName = "Rosaline",
                            Gender = "Agender",
                            Guid = new Guid("f758423e-8547-468c-a898-fdd69958d79a"),
                            LastName = "Stembridge",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 13L,
                            Email = "mishakc@huffingtonpost.com",
                            FirstName = "Mirna",
                            Gender = "Non-binary",
                            Guid = new Guid("a359d78f-d33a-4ec5-bc97-43bef6c0e895"),
                            LastName = "Ishak",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 14L,
                            Email = "sballind@smugmug.com",
                            FirstName = "Siffre",
                            Gender = "Genderqueer",
                            Guid = new Guid("82f10b12-695d-431f-8397-2a0eadccefbf"),
                            LastName = "Ballin",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 15L,
                            Email = "apulhostere@springer.com",
                            FirstName = "Adelle",
                            Gender = "Bigender",
                            Guid = new Guid("039a9be8-b5d5-4640-9ecc-da09046ae53a"),
                            LastName = "Pulhoster",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 16L,
                            Email = "vmcgauhyf@dmoz.org",
                            FirstName = "Valeda",
                            Gender = "Female",
                            Guid = new Guid("35e642a5-13bc-4d1d-8a84-705e4532fdb1"),
                            LastName = "McGauhy",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 17L,
                            Email = "hkubelkag@home.pl",
                            FirstName = "Horatia",
                            Gender = "Bigender",
                            Guid = new Guid("6990b88d-b5ae-4811-9603-4a920920ae76"),
                            LastName = "Kubelka",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 18L,
                            Email = "ebangsh@networksolutions.com",
                            FirstName = "Emmalyn",
                            Gender = "Genderfluid",
                            Guid = new Guid("225521f6-ea2b-4e0c-be3a-c24d46ab83f5"),
                            LastName = "Bangs",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 19L,
                            Email = "ahallardi@smh.com.au",
                            FirstName = "Andres",
                            Gender = "Male",
                            Guid = new Guid("d5f57e15-b2a7-4057-916f-731ab49a6f43"),
                            LastName = "Hallard",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 20L,
                            Email = "jarensj@tripod.com",
                            FirstName = "Juditha",
                            Gender = "Agender",
                            Guid = new Guid("6c9d711d-59af-421c-b297-8bfb0a168362"),
                            LastName = "Arens",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 21L,
                            Email = "eisoldik@ebay.co.uk",
                            FirstName = "Ermentrude",
                            Gender = "Female",
                            Guid = new Guid("74a28896-ca74-4353-95ec-894c7c59244c"),
                            LastName = "Isoldi",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 22L,
                            Email = "mcurpheyl@kickstarter.com",
                            FirstName = "Matty",
                            Gender = "Polygender",
                            Guid = new Guid("8cbde2d2-4e7c-4404-acac-fcb26b974d0f"),
                            LastName = "Curphey",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 23L,
                            Email = "sjulyanm@so-net.ne.jp",
                            FirstName = "Sheffie",
                            Gender = "Polygender",
                            Guid = new Guid("ab13db04-1a86-4644-995f-7fed9e746fcd"),
                            LastName = "Julyan",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 24L,
                            Email = "spopworthn@cbslocal.com",
                            FirstName = "Selina",
                            Gender = "Non-binary",
                            Guid = new Guid("4e90733a-d887-4c03-b91f-f22167ffc3a3"),
                            LastName = "Popworth",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 25L,
                            Email = "dbrecheo@stanford.edu",
                            FirstName = "Darcee",
                            Gender = "Agender",
                            Guid = new Guid("606d07b8-f102-49a3-a1fe-2b77b9938307"),
                            LastName = "Breche",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 26L,
                            Email = "drikkardp@yahoo.co.jp",
                            FirstName = "Donnell",
                            Gender = "Female",
                            Guid = new Guid("6372ee25-9041-4caf-a60c-edfed53e0c83"),
                            LastName = "Rikkard",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 27L,
                            Email = "achickenq@blog.com",
                            FirstName = "Adolph",
                            Gender = "Genderqueer",
                            Guid = new Guid("48954833-1a02-46a3-991d-8740fa54044f"),
                            LastName = "Chicken",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 28L,
                            Email = "zsansomr@php.net",
                            FirstName = "Zorina",
                            Gender = "Male",
                            Guid = new Guid("ea6be99f-7279-4782-b54f-3ecfa3e2d2c1"),
                            LastName = "Sansom",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 29L,
                            Email = "rventums@163.com",
                            FirstName = "Ravid",
                            Gender = "Female",
                            Guid = new Guid("7cdf841e-31db-4aa6-a13d-fe19603b4c43"),
                            LastName = "Ventum",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 30L,
                            Email = "wpidgint@redcross.org",
                            FirstName = "Willie",
                            Gender = "Genderqueer",
                            Guid = new Guid("c048abcc-cb27-4c17-ae20-c238750d1d18"),
                            LastName = "Pidgin",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 31L,
                            Email = "lwasielewskiu@merriam-webster.com",
                            FirstName = "Lora",
                            Gender = "Male",
                            Guid = new Guid("364c5ca3-e642-44ff-8e53-6365e46b728a"),
                            LastName = "Wasielewski",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 32L,
                            Email = "kgapperv@tuttocitta.it",
                            FirstName = "Knox",
                            Gender = "Genderfluid",
                            Guid = new Guid("79d39fe7-a46d-4f60-bb55-3d3d78491467"),
                            LastName = "Gapper",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 33L,
                            Email = "fbartolommeow@issuu.com",
                            FirstName = "Fulton",
                            Gender = "Male",
                            Guid = new Guid("3768d14b-45f7-4dfb-b0d7-0ccf5c0d47d5"),
                            LastName = "Bartolommeo",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 34L,
                            Email = "sklebesx@opera.com",
                            FirstName = "Simona",
                            Gender = "Genderfluid",
                            Guid = new Guid("318b7966-a974-4b8c-9011-67d220f9a1ca"),
                            LastName = "Klebes",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 35L,
                            Email = "kbulchy@goo.gl",
                            FirstName = "Kelci",
                            Gender = "Genderfluid",
                            Guid = new Guid("d2eb436c-f88b-4af4-a3ba-64c13cf18823"),
                            LastName = "Bulch",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 36L,
                            Email = "lricketz@networksolutions.com",
                            FirstName = "Lonnie",
                            Gender = "Genderfluid",
                            Guid = new Guid("232dad51-34b1-4648-be8f-2fb21e025c69"),
                            LastName = "Ricket",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 37L,
                            Email = "nmilthorpe10@utexas.edu",
                            FirstName = "Norean",
                            Gender = "Genderfluid",
                            Guid = new Guid("479ed05f-85d5-48e2-8b70-4be1ef1e4228"),
                            LastName = "Milthorpe",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 38L,
                            Email = "showlett11@yandex.ru",
                            FirstName = "Sue",
                            Gender = "Genderfluid",
                            Guid = new Guid("e35caae3-ecec-46f8-a4fb-4aa82ed13637"),
                            LastName = "Howlett",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 39L,
                            Email = "sleser12@theglobeandmail.com",
                            FirstName = "Sidnee",
                            Gender = "Bigender",
                            Guid = new Guid("d491b9c3-b631-4a17-b799-e94e4e0cb94f"),
                            LastName = "Leser",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 40L,
                            Email = "cstrettell13@123-reg.co.uk",
                            FirstName = "Cynthie",
                            Gender = "Agender",
                            Guid = new Guid("89e58be5-9156-44c2-8ccb-4490a57823ee"),
                            LastName = "Strettell",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 41L,
                            Email = "tdoggett14@amazon.co.uk",
                            FirstName = "Tome",
                            Gender = "Bigender",
                            Guid = new Guid("2b8115fc-4396-430e-ab7c-c344d2fe8765"),
                            LastName = "Doggett",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 42L,
                            Email = "tpaget15@rakuten.co.jp",
                            FirstName = "Tiertza",
                            Gender = "Genderfluid",
                            Guid = new Guid("7b1f767a-0ec9-48a9-9f26-6b488b85d068"),
                            LastName = "Paget",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 43L,
                            Email = "wmedford16@baidu.com",
                            FirstName = "Wolfie",
                            Gender = "Agender",
                            Guid = new Guid("11e49fce-0513-4280-a3bc-a6907a39ef85"),
                            LastName = "Medford",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 44L,
                            Email = "gkeuneke17@reference.com",
                            FirstName = "Galvin",
                            Gender = "Agender",
                            Guid = new Guid("ad1f0ae9-af27-48c8-8754-676021fae2c7"),
                            LastName = "Keuneke",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 45L,
                            Email = "lpatis18@multiply.com",
                            FirstName = "Lainey",
                            Gender = "Genderfluid",
                            Guid = new Guid("e486a6c4-6d5b-4c36-9ec7-1b409da071e0"),
                            LastName = "Patis",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 46L,
                            Email = "dbrumbye19@is.gd",
                            FirstName = "Domini",
                            Gender = "Genderfluid",
                            Guid = new Guid("40bc03c7-8aaa-449f-9d66-2512450528c8"),
                            LastName = "Brumbye",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 47L,
                            Email = "pmacdougall1a@w3.org",
                            FirstName = "Prentiss",
                            Gender = "Bigender",
                            Guid = new Guid("1ca792eb-bda3-497b-9de7-5b9c528d35a4"),
                            LastName = "MacDougall",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 48L,
                            Email = "scolaco1b@weibo.com",
                            FirstName = "Sheri",
                            Gender = "Agender",
                            Guid = new Guid("43212be8-e609-44b5-b94f-a1fc1f3009f3"),
                            LastName = "Colaco",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 49L,
                            Email = "msabbin1c@google.ca",
                            FirstName = "Millard",
                            Gender = "Agender",
                            Guid = new Guid("0f8054d2-cae5-4516-96db-2c3658d4bd79"),
                            LastName = "Sabbin",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 50L,
                            Email = "dskaif1d@so-net.ne.jp",
                            FirstName = "Dorelle",
                            Gender = "Male",
                            Guid = new Guid("2ff851dd-9954-463f-83c2-82d46205432a"),
                            LastName = "Skaif",
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
