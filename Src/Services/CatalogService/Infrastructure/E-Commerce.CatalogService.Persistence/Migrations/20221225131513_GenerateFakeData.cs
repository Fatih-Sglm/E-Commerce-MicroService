using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECommerce.CatalogService.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class GenerateFakeData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Brand",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 16, 15, 13, 149, DateTimeKind.Local).AddTicks(8143));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Brand",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 16, 15, 13, 149, DateTimeKind.Local).AddTicks(8157));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Brand",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 16, 15, 13, 149, DateTimeKind.Local).AddTicks(8158));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 16, 15, 13, 150, DateTimeKind.Local).AddTicks(6331));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 16, 15, 13, 150, DateTimeKind.Local).AddTicks(6340));

            migrationBuilder.InsertData(
                schema: "catalog",
                table: "Catalog_Item",
                columns: new[] { "Id", "CatalogBrandId", "CatalogTypeId", "CreatedDate", "Description", "Name", "Price", "UpdatedDate" },
                values: new object[,]
                {
                    { 10032L, 2L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vitae rem reprehenderit quis. Labore et necessitatibus et porro ab perspiciatis consequatur. Dolore est voluptas doloremque omnis. İn omnis quis. Earum totam a aliquam id ut et qui.", "Small Steel Ball", 636.70m, null },
                    { 10033L, 3L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ab ea illo rem est cum maxime quasi non quo. Occaecati dolores facere expedita. Et laboriosam temporibus nihil voluptatem libero dolorem velit nostrum beatae. Doloremque non velit eum consequatur deleniti vel.", "Licensed Plastic Car", 167.28m, null },
                    { 10034L, 1L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cumque est tempore reprehenderit architecto dolores dolorem. Quod necessitatibus id et vel veniam autem sed. Eligendi dolores nihil sunt officia omnis quia quia nulla. Saepe est et voluptatem laboriosam iure corrupti distinctio.", "Practical Plastic Sausages", 705.14m, null },
                    { 10035L, 1L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Est inventore rerum est eos. Reiciendis qui iure et sint. Fugit eius sit voluptatem iste modi. Unde pariatur et. İllo expedita voluptatem autem illum dolores nisi ipsam officia. Aut minus alias veritatis corrupti omnis explicabo quas modi at.", "Intelligent Plastic Computer", 838.88m, null },
                    { 10036L, 1L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "İmpedit nam amet. Possimus voluptas aliquid at est est esse id. Laboriosam doloremque est molestiae autem.", "Small Rubber Table", 270.45m, null },
                    { 10037L, 3L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Autem facilis quaerat laborum aut. Et omnis sit est. Et quaerat enim aut reprehenderit. Ut dolore voluptates fugit eveniet ipsam sapiente explicabo. Ullam qui et. Dolor et aut recusandae aut quod.", "Rustic Soft Gloves", 690.92m, null },
                    { 10038L, 2L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ut minima doloribus maxime. Laborum dolorem dicta rerum quia. Et nulla omnis. Labore et tempora maiores. Porro nulla fugiat facere ipsum.", "Generic Frozen Bacon", 602.22m, null },
                    { 10039L, 3L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nihil corporis voluptatem alias animi. Tempore facere sunt praesentium. Labore libero magnam optio voluptatem praesentium explicabo. Perspiciatis vitae sunt eos rerum asperiores minima necessitatibus laboriosam est. Totam non sunt alias voluptas aut. Neque rerum recusandae quisquam consequatur sint maiores et explicabo.", "Sleek Granite Fish", 965.92m, null },
                    { 10040L, 3L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quos optio maxime. Excepturi impedit et ut id neque et facere libero non. Voluptatem possimus placeat nesciunt sed quas delectus omnis. Nulla doloribus et.", "Intelligent Wooden Shoes", 811.62m, null },
                    { 10041L, 2L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aut beatae nemo et sint. Eos nostrum sequi aut unde impedit inventore rerum sapiente. Molestiae eos ipsum voluptas velit quis. Repellendus consequatur ullam est cum aliquid. Alias quam nam totam voluptates natus aut officiis. Ab et doloribus repudiandae nihil et.", "Ergonomic Plastic Shoes", 736.08m, null },
                    { 10042L, 3L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quae reiciendis modi facere harum beatae dolorem pariatur perspiciatis minima. Tempore rerum incidunt eum necessitatibus est. Sed sapiente et at modi libero quia blanditiis.", "Practical Concrete Shirt", 928.52m, null },
                    { 10043L, 3L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Omnis consectetur voluptatibus sint voluptas expedita accusantium deserunt tenetur ab. Perferendis sint molestiae natus autem corrupti. Vel quod tempore nemo dolore aspernatur unde.", "Sleek Fresh Shoes", 952.68m, null },
                    { 10044L, 1L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Est eligendi hic officia ea perspiciatis omnis. Perferendis cumque voluptatem ullam et debitis. Magnam dolores in dolor molestias. Omnis aliquam atque quaerat dolores ut ut qui.", "Handmade Cotton Shirt", 23.85m, null },
                    { 10045L, 2L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Totam possimus atque aut quia ut rerum. Sapiente maxime assumenda nobis sit. Ut ut sint qui. Dicta mollitia adipisci est ex ipsa. Odit provident labore ut cupiditate quia sint quod neque.", "Incredible Plastic Shirt", 887.89m, null },
                    { 10046L, 1L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Est qui sit et sed harum et atque. Culpa hic dignissimos in quas perspiciatis aliquid animi dolores. Dolorem et in qui eos.", "Rustic Soft Gloves", 592.04m, null },
                    { 10047L, 3L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animi id sequi nobis vitae est labore qui nesciunt nesciunt. Eaque veniam et modi unde. Sunt eveniet quas aliquam consequatur.", "Sleek Soft Chips", 169.12m, null },
                    { 10048L, 1L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "İn reiciendis qui totam veniam. Et error voluptatem. Sint voluptas explicabo dolores est error eius at non odit. Saepe laborum deserunt deleniti eum distinctio velit ut deserunt. Nihil error aliquam quam maxime corporis id. Mollitia dolorem unde quas quia et perspiciatis necessitatibus.", "Handmade Steel Pizza", 258.17m, null },
                    { 10049L, 1L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Consectetur explicabo rerum. Aut porro mollitia est nulla qui voluptatibus accusamus. Reprehenderit voluptatem et magnam quia.", "Tasty Fresh Chips", 800.13m, null },
                    { 10050L, 2L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Molestiae distinctio placeat aliquid amet. Quaerat itaque voluptatibus nulla est molestiae mollitia minus error quidem. Non soluta veritatis qui tempora sed libero. Eaque error mollitia et architecto qui hic.", "Tasty Steel Computer", 4.51m, null },
                    { 10051L, 2L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "İste dolore vitae quibusdam sed maiores perferendis iste. Ullam qui qui quod quasi aspernatur. Porro distinctio pariatur voluptates ducimus consectetur eaque.", "Tasty Cotton Car", 27.55m, null },
                    { 10052L, 1L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Praesentium sunt ut expedita magnam aperiam similique ipsa. Dolor perferendis ut iure et et. Occaecati ut alias repellat vero omnis voluptas dolorem commodi ipsa. Et unde totam officiis blanditiis. Aut aut nihil.", "Fantastic Cotton Car", 286.46m, null },
                    { 10053L, 2L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Odio molestias voluptates nihil velit ea autem nisi provident. Aliquid ut veniam repellendus. Nulla sequi dicta enim aut quaerat voluptates rem dolores. Molestiae quod perferendis aut velit odit voluptates laborum quis modi. Voluptas doloremque distinctio ratione fugit quae ea rerum. Placeat porro rem ut quas velit illum.", "Handcrafted Plastic Bike", 997.74m, null },
                    { 10054L, 3L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ut pariatur nemo aut officiis quis consectetur ipsa occaecati. Nulla qui dicta. Repellendus quis nemo adipisci sunt modi neque eaque dolore quod. Reprehenderit quisquam in facere quod quasi sed.", "Intelligent Cotton Chicken", 102.72m, null },
                    { 10055L, 3L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Molestias consequatur voluptate rem occaecati veniam exercitationem dolor. Dicta harum modi quis. Vitae pariatur incidunt enim.", "Licensed Metal Cheese", 281.94m, null },
                    { 10056L, 3L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quia quia eos qui et ipsa earum nisi. İnventore dolorem ad sed culpa. Eius deleniti quisquam. Consectetur ipsam quia qui. Expedita eum tenetur eos et consequatur.", "Handcrafted Metal Cheese", 246.45m, null },
                    { 10057L, 3L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aut ratione voluptatum sit nesciunt sed. Nemo praesentium dolore porro soluta nemo error maxime numquam qui. Eum rerum est rerum quis laudantium. Harum incidunt blanditiis labore ratione sint. Ab natus sed.", "Gorgeous Rubber Bacon", 837.01m, null },
                    { 10058L, 1L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Perferendis eos illum. Eos omnis et voluptate voluptatem. Omnis similique magnam a accusantium est eius consectetur ut. Animi nisi odio voluptatem est ut non enim. Adipisci sed provident vero eveniet non. Et est nobis quibusdam sit error.", "Handmade Granite Fish", 400.18m, null },
                    { 10059L, 2L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nihil omnis non non earum officiis. Repudiandae excepturi blanditiis qui adipisci necessitatibus. Asperiores quas quaerat exercitationem ut repellendus porro rerum fugiat. Reiciendis perferendis modi. Minima omnis ut recusandae et asperiores hic consequatur.", "Tasty Cotton Sausages", 538.70m, null },
                    { 10060L, 1L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Labore est quo eum et perspiciatis eos occaecati repudiandae eos. Animi animi nihil voluptas accusantium. Nulla exercitationem consequatur. Eligendi sint adipisci. Quia reprehenderit doloremque alias nobis ipsam et consequatur.", "Sleek Fresh Shirt", 680.84m, null },
                    { 10061L, 1L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Consequatur neque porro quasi consectetur suscipit quos et ut est. Provident adipisci velit quaerat. Non quia optio recusandae qui tempore esse. Quos saepe quibusdam est qui quasi molestiae velit non. Beatae ut qui. Sit voluptatibus tenetur cum qui quasi qui.", "Tasty Cotton Ball", 62.19m, null },
                    { 10062L, 1L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sit omnis dolore animi aspernatur ut repudiandae dolor. Dolorum iste nam expedita reprehenderit sunt vero aspernatur ad. Quia ex suscipit labore dolorem magni autem voluptas libero. Similique nostrum asperiores est ullam quasi asperiores minus laborum. Nobis dolorum debitis incidunt.", "Small Rubber Sausages", 846.40m, null },
                    { 10063L, 2L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolorum explicabo ab ipsa. Amet autem optio laudantium excepturi praesentium ab fugit. Aut ex voluptatem laudantium eligendi ipsum minus. Accusamus omnis ullam nostrum voluptatem quia sunt soluta corrupti. Veniam veritatis consequuntur vitae.", "Fantastic Metal Gloves", 225.43m, null },
                    { 10064L, 1L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "İpsa ipsam non sed quia ad quasi ipsum dolores. Tempore earum vel laboriosam a quae ut consectetur consectetur quia. Blanditiis dolor nobis nisi.", "Rustic Wooden Cheese", 168.25m, null },
                    { 10065L, 2L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Molestiae culpa odio ut quae aspernatur eius tenetur reprehenderit et. Odit ex quae enim. Vel quaerat earum hic quisquam. Qui laboriosam architecto animi necessitatibus quo asperiores enim. Recusandae error rem autem eum ea officia eum debitis. Quo fugit voluptatem doloremque fugiat non voluptate iusto labore.", "Practical Steel Keyboard", 180.37m, null },
                    { 10066L, 1L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hic nesciunt nihil nihil aut et voluptate et architecto dicta. Est aspernatur omnis sit odit. Veritatis enim earum beatae qui ipsum aspernatur quidem qui. Laudantium qui laboriosam quo non omnis. Temporibus sit consequatur quia laudantium. Dolorem dolorem omnis dolor cum ea.", "Intelligent Concrete Keyboard", 145.42m, null },
                    { 10067L, 3L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et laudantium officia rerum qui reprehenderit in soluta. Ut excepturi recusandae. Enim reprehenderit omnis numquam repudiandae. İure est rerum eum. At fuga id sit voluptatibus cum quidem.", "Ergonomic Cotton Towels", 484.44m, null },
                    { 10068L, 2L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Omnis qui aperiam excepturi ea laborum quidem eius. Quod libero adipisci. Qui rem dolorum magnam a quasi.", "Gorgeous Granite Bacon", 952.45m, null },
                    { 10069L, 3L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Exercitationem eligendi totam totam sequi quaerat repellat quam harum et. Aut ipsum deserunt dolores non est et. Nam aut eaque voluptatem. Natus consequuntur est autem et in sed ducimus ea sapiente. Dolores sit ut ut eos et ducimus aperiam quis totam.", "Licensed Rubber Cheese", 530.21m, null },
                    { 10070L, 3L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Est et iste nihil in eos similique veritatis culpa unde. Beatae aut adipisci ut facilis sunt quod maxime asperiores non. İllum libero vel sit architecto harum earum. Et eligendi qui soluta quis consequatur dolorem eos eaque.", "Licensed Plastic Bacon", 869.25m, null },
                    { 10071L, 1L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ut iure quia architecto excepturi. Est distinctio quod sit tenetur accusantium ea et vitae. Magni nesciunt quidem culpa ratione aspernatur unde dolor ut molestiae. Ad vel recusandae alias voluptatem animi.", "Handmade Rubber Table", 202.31m, null },
                    { 10072L, 3L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Similique velit quaerat quisquam et cupiditate tenetur eum qui. Et molestias hic aut ullam. Amet eveniet officia. Qui id ipsam omnis laborum vel facilis dolores aperiam modi. Ea rerum expedita.", "Practical Fresh Tuna", 822.51m, null },
                    { 10073L, 2L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aut et laborum sed eum odio. Tenetur nisi sit molestiae rem. Dolores possimus corporis rerum quos aperiam labore nemo totam autem.", "Incredible Granite Towels", 913.29m, null },
                    { 10074L, 3L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Est maiores modi maiores officia sed beatae placeat aut optio. Et quis dolor autem hic. Reiciendis itaque deserunt quia sit similique velit eum sunt.", "Refined Granite Sausages", 494.05m, null },
                    { 10075L, 2L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Totam necessitatibus distinctio error commodi dignissimos assumenda molestiae itaque. Molestiae doloribus minima molestiae provident velit explicabo odio. At eum minima sed.", "Handcrafted Cotton Computer", 284.69m, null },
                    { 10076L, 2L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nulla nam minima harum eum. Quasi aut est harum velit enim quis. Aut tenetur enim ullam sit perferendis. Vero officiis nesciunt dolorem dolorem sunt ratione eligendi. Et similique et et commodi fuga non quo optio. İnventore voluptas aut.", "Awesome Frozen Cheese", 892.54m, null },
                    { 10077L, 3L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quod aut laborum ut sit provident harum molestiae. Rerum dignissimos hic exercitationem vel ea cupiditate voluptates. Vitae magni sunt id eos molestias enim. Sed corporis consectetur excepturi et quidem molestiae. Cupiditate facilis vitae sed quia.", "Generic Cotton Sausages", 133.77m, null },
                    { 10078L, 1L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "İd quae velit ea sequi distinctio quaerat sit voluptas repellat. Aut ratione sit mollitia totam voluptatem voluptate veniam aut. Quis modi amet. Magnam omnis omnis. Voluptatibus beatae exercitationem ea quidem sunt eveniet perferendis facere ducimus.", "Generic Wooden Ball", 856.22m, null },
                    { 10079L, 2L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aut tenetur consectetur a maxime. Eum vel corrupti ipsum unde quia eveniet nostrum. Et officiis nisi velit minima eligendi consequatur quia quia.", "Handcrafted Plastic Chair", 490.82m, null },
                    { 10080L, 3L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "İllo aliquid illum eaque deserunt consequatur iusto quis dolor. Corporis quia sit laborum quam minima. Culpa est ratione voluptatibus est. Neque illum sit officia labore ipsam eligendi odio et. Sit voluptatem facilis delectus ipsa eos error.", "Tasty Rubber Computer", 987.21m, null },
                    { 10081L, 1L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Provident praesentium quo quas dolor blanditiis omnis neque expedita. Omnis voluptas fugit placeat iusto veritatis. Est sit est saepe quod ut ex.", "Licensed Metal Fish", 250.00m, null },
                    { 10082L, 1L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enim ut aliquid ex voluptas id dicta harum. Cumque corporis corrupti dicta et cumque consectetur ipsum odit. İmpedit quos quidem quod neque vel unde labore ex. Et accusantium qui iure non reiciendis architecto maxime rerum delectus. Alias accusamus et deserunt minus.", "Sleek Cotton Table", 825.07m, null },
                    { 10083L, 2L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Culpa dolore laboriosam quod pariatur laborum consequatur et enim. Maxime ut illo fuga. Provident ipsa tempore nobis ut omnis et.", "Tasty Concrete Hat", 762.43m, null },
                    { 10084L, 1L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "İncidunt quas impedit adipisci non magni sint amet. Veniam et expedita in vel alias ut fugit deleniti. Dicta autem harum unde cumque blanditiis veniam et impedit accusamus. Nemo aliquam repudiandae omnis aut aut ipsum. Quia exercitationem sequi ea. Atque cupiditate rem porro eum libero.", "Incredible Rubber Towels", 628.15m, null },
                    { 10085L, 3L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobis quis sunt doloribus corrupti itaque libero. Quisquam fugit omnis aut aut et odit. Libero velit nobis et dolores praesentium omnis.", "Generic Plastic Hat", 351.76m, null },
                    { 10086L, 1L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nihil commodi et reprehenderit. Non sint aperiam omnis. Et distinctio quas veniam est omnis.", "Handmade Steel Ball", 590.22m, null },
                    { 10087L, 3L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Soluta eligendi eos officia recusandae omnis laboriosam sit quis repudiandae. Sed cumque eligendi ullam doloremque distinctio quod. Sunt expedita quidem et. Officiis ut sit. Et laborum sapiente dolore sunt recusandae inventore et et ex. Dolores nemo sed modi aut nesciunt nihil ullam.", "Licensed Rubber Table", 677.73m, null },
                    { 10088L, 2L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptate distinctio quia quisquam aut nisi accusamus nobis voluptatibus. Veniam quibusdam labore. Ut qui et dolore quas sit consequatur nostrum. Recusandae aut tempore cum rerum vel in voluptate porro.", "Ergonomic Rubber Car", 132.80m, null },
                    { 10089L, 3L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cum non aut rem incidunt et omnis sunt sed. Et doloribus quis impedit quia. Rerum eum sint. Quo inventore quos doloremque ut voluptatem error tenetur.", "Handcrafted Wooden Shirt", 48.96m, null },
                    { 10090L, 1L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "İncidunt accusamus aliquid dolor molestiae. Qui sequi voluptas est consequatur. Repellat ut tempore quae. Neque culpa a ut. İtaque molestiae pariatur et aut error alias sed sequi.", "Intelligent Granite Car", 711.96m, null },
                    { 10091L, 1L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reprehenderit quia quam consectetur alias. Doloremque qui incidunt dolorem provident ab delectus expedita. Nobis facere a. Deleniti sequi dolorum est itaque veritatis occaecati pariatur perspiciatis provident. Quae tempore et vero et. İure ut a atque accusantium aut id.", "Small Cotton Towels", 301.72m, null },
                    { 10092L, 3L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vero nam rerum ut pariatur reprehenderit. Tempora aperiam accusantium in et laborum delectus. Aut quis nostrum beatae rerum illo neque sunt.", "Licensed Fresh Bacon", 138.65m, null },
                    { 10093L, 3L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aperiam fuga molestias qui. Eligendi ducimus voluptatum aliquid consequatur eos possimus consequatur non exercitationem. Eos repellat provident sit dolor. Aut voluptatem et ipsum ipsum aliquid ut aut. Rerum dicta dicta voluptas modi. Consequuntur rerum neque et nihil quidem pariatur alias vel.", "Rustic Rubber Bike", 194.14m, null },
                    { 10094L, 2L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quas quo itaque rerum officiis quisquam at deserunt praesentium consectetur. Dignissimos rerum quaerat quia et et blanditiis repudiandae iste. Eveniet voluptates omnis doloribus laboriosam ducimus officia et impedit in.", "Sleek Plastic Shoes", 911.40m, null },
                    { 10095L, 3L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolores rerum vero dolores et qui. Dolore id quod eum qui nesciunt. Autem sit deserunt deleniti atque dolores. Et aspernatur consequatur fugiat eum cum est eligendi qui est. İn id aut eum et sint laborum et excepturi.", "Tasty Fresh Pants", 613.24m, null },
                    { 10096L, 2L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sint voluptatem modi. Et inventore omnis culpa. Explicabo amet qui sed quisquam exercitationem nulla qui. Accusantium adipisci aliquid consequatur iusto. Minima veritatis facilis id quo dicta omnis quos magni ullam. A rem animi corrupti minus velit ducimus earum.", "Ergonomic Fresh Pants", 578.88m, null },
                    { 10097L, 2L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ullam cum et molestias nulla et. Neque labore aperiam eligendi temporibus harum natus. Temporibus voluptates fugiat soluta voluptatum.", "Incredible Metal Gloves", 109.29m, null },
                    { 10098L, 2L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Similique nemo omnis et rerum. Corrupti provident cum ratione consequuntur molestiae. Rem ipsum sint sunt rem aut consequatur labore et. Provident voluptas optio molestiae voluptatem velit. Ducimus quia voluptatem autem aspernatur quaerat unde veritatis.", "Sleek Metal Fish", 660.46m, null },
                    { 10099L, 1L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accusantium in qui dolor doloremque. Voluptatibus modi ab quod delectus et. Tempora et magni id illo esse eaque.", "Small Frozen Gloves", 748.39m, null },
                    { 10100L, 3L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Debitis quia illo ipsa nostrum animi eos sed sequi. Ut officiis impedit aut autem. Perferendis commodi qui repellat quasi. Consequuntur nam voluptatem veritatis voluptas occaecati at et laudantium. Tempora sint et saepe aut quos.", "Sleek Plastic Towels", 380.48m, null },
                    { 10101L, 3L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et vitae et dolor sunt nobis inventore reprehenderit est eius. Voluptate voluptatem reprehenderit cumque consequatur. Praesentium corporis consectetur quia dicta asperiores eligendi et. Aliquam quisquam non. Sequi sunt placeat atque culpa ut aut praesentium. Nemo nostrum porro totam error.", "Fantastic Plastic Table", 619.42m, null },
                    { 10102L, 1L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "İnventore quos ipsum. Sint ut et et quas consequuntur aliquid dicta minima. Quia reprehenderit ipsum possimus labore. İllum nemo minus veritatis reprehenderit a ut tenetur assumenda voluptatem. Accusantium dolore commodi accusamus. Numquam quis fuga velit minima quidem.", "Practical Granite Cheese", 792.96m, null },
                    { 10103L, 2L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "İusto et ut ipsa nesciunt eligendi sint doloremque quo. Eum deserunt labore vitae delectus eum dolores. Soluta sit vel nihil laborum dolore totam ut aut aspernatur.", "Ergonomic Metal Shirt", 378.51m, null },
                    { 10104L, 3L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "İpsam aut sit sunt voluptatum quis voluptatem quia. Corporis aliquam aut doloremque nam impedit omnis. Non iste quasi ab. Pariatur dignissimos non libero enim repellendus praesentium expedita rerum.", "Sleek Steel Mouse", 248.66m, null },
                    { 10105L, 2L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quis quia illo. Enim est ut eligendi sed voluptates ut quibusdam. İncidunt vel rerum vitae et magni voluptas numquam. Ut eius ut unde non vel voluptatem eaque voluptas. Aut et commodi numquam aut. İpsa aliquid dolorum aut.", "Small Frozen Fish", 663.33m, null },
                    { 10106L, 1L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Neque quaerat cum unde commodi inventore quia expedita. Aliquid porro illo fugit maxime alias repellendus id blanditiis et. Accusamus dolorem dicta. Dolorem ducimus et adipisci sapiente ut. İste quo facilis corporis illo. Nam labore dolores quas.", "Rustic Rubber Shoes", 606.50m, null },
                    { 10107L, 2L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Labore rerum cum aliquid quia nobis. İpsa deleniti eum quo nulla quod. Sequi incidunt soluta repellendus nihil rerum. Consectetur aspernatur quia id necessitatibus sit quisquam veritatis ea. Modi magni eum quia aperiam non.", "Small Plastic Chair", 122.95m, null },
                    { 10108L, 2L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et corporis dolore perferendis quibusdam necessitatibus qui veniam voluptatum. İd commodi non tenetur excepturi. Ea libero quae est sed quisquam at itaque et velit. Porro veritatis ad aut illum rerum consequatur.", "Licensed Steel Tuna", 780.41m, null },
                    { 10109L, 3L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unde sequi nesciunt. İd rerum nihil distinctio. Tenetur quisquam aut eaque voluptates iusto rerum. Quo nostrum et rerum eligendi et voluptatem ipsa rerum aut. Nihil possimus fuga tempore quaerat.", "Unbranded Concrete Shoes", 544.08m, null },
                    { 10110L, 1L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Exercitationem modi consequatur. İpsum earum tempore dolores voluptatem commodi autem quibusdam. Eligendi maiores omnis et est. Architecto ex molestiae tempore ipsam cum sit. Voluptas possimus magnam. Ut voluptates dolor ipsam repudiandae odio voluptate vero sit.", "Generic Plastic Shoes", 42.63m, null },
                    { 10111L, 2L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Qui ipsam in sit fuga quia tenetur molestiae. Vero est consectetur dolorem commodi iure eos minima. Et mollitia dolorem soluta inventore enim consequatur blanditiis aut voluptatibus.", "Unbranded Soft Salad", 952.55m, null },
                    { 10112L, 2L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Perferendis iste inventore dolores id error. Architecto id beatae qui enim voluptatem eligendi velit cupiditate expedita. Ut architecto vitae debitis sequi ut ducimus quasi sed voluptatum.", "Tasty Plastic Sausages", 372.11m, null },
                    { 10113L, 3L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Corporis qui ad et accusantium dolores placeat. Nobis aperiam ut animi est consequatur. Veniam et dolorum ducimus in numquam dolorem. Voluptas facere libero praesentium commodi maxime sint ut provident. Deleniti aut dolorem rem consequatur molestiae consequatur. Praesentium sapiente laborum consequatur.", "Rustic Fresh Fish", 375.31m, null },
                    { 10114L, 1L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolor id neque ullam eaque nihil temporibus. At vitae deserunt quod est necessitatibus illum non. Dolorem in mollitia id nihil. Quos aut voluptatem optio explicabo est iste id harum. Et sit autem praesentium nemo assumenda magnam est quisquam.", "Fantastic Granite Towels", 36.20m, null },
                    { 10115L, 1L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Est error ea voluptatum ut tenetur et nesciunt. Dolorem suscipit recusandae non dolore voluptates voluptate. Est repellendus recusandae similique qui quia. Rem saepe ipsum vitae consequuntur et nulla. Nemo molestias fugiat.", "Handmade Frozen Gloves", 243.66m, null },
                    { 10116L, 2L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Magnam modi corrupti et. Delectus ut aperiam quidem et tenetur vero earum. Modi sed quam quas eveniet ea itaque aliquam. Unde sapiente odit quia.", "Small Metal Computer", 856.27m, null },
                    { 10117L, 1L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Corporis sequi voluptate ratione corrupti eos qui iusto. Nisi voluptas at enim molestiae aut. Soluta optio ut. Qui vitae distinctio fuga placeat. Qui et voluptate beatae nisi. Cumque occaecati minima inventore esse eum nulla.", "Ergonomic Granite Pizza", 107.45m, null },
                    { 10118L, 3L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nulla expedita quo omnis porro eveniet enim assumenda. Pariatur pariatur quo. Est aperiam molestiae cupiditate doloremque libero rerum commodi. İpsum et vero aut. Soluta quas expedita. Voluptatem ex omnis debitis voluptate commodi vel id.", "Tasty Cotton Chicken", 933.86m, null },
                    { 10119L, 1L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptas eum consequatur tempora incidunt est officiis iusto nesciunt soluta. Temporibus iure illum. İste id laboriosam itaque placeat a. Ut eum odit. Sint aut unde voluptatibus. Veritatis fugit necessitatibus similique.", "Fantastic Plastic Towels", 821.31m, null },
                    { 10120L, 3L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Odio rerum qui perferendis adipisci voluptas nobis qui architecto ipsam. Totam delectus aut reprehenderit exercitationem repellat debitis. A voluptatibus perspiciatis repellat vero excepturi.", "Handcrafted Frozen Pizza", 777.75m, null },
                    { 10121L, 1L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "İllo assumenda voluptas nostrum. Ea eum nisi odit assumenda est in est aperiam. Quibusdam sequi voluptatem mollitia delectus qui aut sit quae. Eos sit odio qui soluta sed dolores est est autem.", "Incredible Rubber Salad", 981.87m, null },
                    { 10122L, 3L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Veritatis quis natus inventore assumenda et quis. Corporis voluptate natus eaque nostrum tempore nisi dolorum quidem ut. Sit tenetur fuga quia sapiente tenetur. Et enim autem voluptatem recusandae sed inventore omnis.", "Handcrafted Granite Cheese", 741.53m, null },
                    { 10123L, 2L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptatem similique suscipit in. Et vero laboriosam necessitatibus sequi. İpsum minus quia reprehenderit esse recusandae aut fugit nihil explicabo.", "Ergonomic Wooden Fish", 881.02m, null },
                    { 10124L, 2L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Provident enim laudantium numquam. Velit aut sit qui deleniti libero quos labore reprehenderit. Possimus quia repudiandae a. Amet voluptas aliquid quia ipsum.", "Fantastic Granite Tuna", 164.21m, null },
                    { 10125L, 3L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aut voluptates corporis et nisi laboriosam qui. Corporis cum vel quos pariatur eum omnis ratione sint. İd earum et nisi magni aut natus architecto cumque. Nemo id dicta et maiores inventore ut unde. Nobis nemo dolore ullam voluptas culpa. Aut facilis consequatur occaecati nostrum et.", "Ergonomic Cotton Towels", 280.17m, null },
                    { 10126L, 3L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sed quaerat aperiam aut consequatur. Voluptas harum doloribus excepturi quos. Ut sed labore commodi eum nulla fuga doloribus nobis est. Ut in perspiciatis consectetur quis nihil nisi voluptatibus voluptas libero.", "Small Steel Chicken", 914.53m, null },
                    { 10127L, 2L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Odio vel ipsam qui minima molestiae consectetur ullam. Quis in quae. Eos reprehenderit ullam itaque voluptatem quam. Accusantium quia aut.", "Fantastic Granite Tuna", 313.28m, null },
                    { 10128L, 1L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Odit molestiae doloremque ad amet. Asperiores qui dolor doloribus voluptates error. Quidem sed in. Consequatur fuga dolorum adipisci laboriosam quaerat in itaque incidunt qui.", "Refined Metal Cheese", 41.70m, null },
                    { 10129L, 1L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Earum quo repellat. Ratione minus quasi est voluptatem. İncidunt quo est possimus commodi ad et quidem. Qui tempore dolor tempore perspiciatis odio ullam. Fuga iste voluptatem nesciunt dolor sit. Officiis itaque nisi.", "Sleek Concrete Pants", 566.80m, null },
                    { 10130L, 3L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harum at illo occaecati expedita iusto alias quidem corrupti consequuntur. Et voluptas facilis enim sed voluptatem ea. Eligendi aut molestiae aliquam ea. Architecto ut molestiae dignissimos itaque amet.", "Fantastic Soft Pizza", 145.89m, null },
                    { 10131L, 2L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quo sapiente rerum eius. Hic quia sint molestiae sint est facere commodi. Velit totam quasi dolore est non.", "Gorgeous Metal Computer", 379.82m, null },
                    { 10132L, 1L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sit non neque omnis in eos aut aut. Earum et voluptates explicabo. Velit rem qui animi tempore. Dolor ipsum dolorem ut optio quaerat porro in. Vitae quibusdam architecto. Expedita itaque quod consequatur fuga qui.", "Rustic Plastic Keyboard", 210.83m, null },
                    { 10133L, 2L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A aperiam et exercitationem sint in impedit autem non quia. Et aut quia cupiditate. Cumque natus voluptatem sapiente amet odit officia eum. Nulla labore doloribus delectus qui harum temporibus nihil porro. İtaque sed corrupti hic iste quod aspernatur quis. Voluptatem exercitationem a pariatur expedita.", "Handcrafted Plastic Computer", 819.65m, null },
                    { 10134L, 1L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nam sunt quia asperiores quia. Quisquam nisi necessitatibus quaerat accusamus cum recusandae eligendi fugiat. Autem ex voluptas exercitationem quidem nulla. İd atque distinctio qui quos enim beatae. Atque ullam iste est facere numquam sed minus reiciendis. Voluptatum alias aut.", "Incredible Plastic Table", 647.04m, null },
                    { 10135L, 1L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptatem itaque accusantium itaque omnis distinctio illum quia et. Omnis perferendis praesentium culpa quas totam iste. Aspernatur velit laboriosam aut sint alias. Non aperiam et ut ipsa ea velit numquam et.", "Incredible Fresh Pizza", 389.76m, null },
                    { 10136L, 2L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sed labore tenetur omnis ab harum. Quasi dolorem quaerat reprehenderit. Molestiae exercitationem est ad nulla sit.", "Tasty Soft Chicken", 291.22m, null },
                    { 10137L, 1L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dignissimos et totam autem non similique qui ea. Officia placeat voluptatibus. Qui dignissimos est corporis cumque vel et beatae natus.", "Sleek Concrete Chair", 937.24m, null },
                    { 10138L, 3L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Praesentium eaque maiores quisquam ullam ut pariatur. Sed itaque sed. Et dolor itaque occaecati neque maiores. Ad et rem vel. Cum ut voluptates totam officiis corporis totam doloribus et.", "Fantastic Plastic Chips", 203.77m, null },
                    { 10139L, 3L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quia blanditiis nobis inventore non itaque sit. Ut porro recusandae provident reiciendis quas accusamus. Ullam quam qui pariatur et ab. Maiores eum ut dolores accusantium minus est. Odit quas cupiditate dignissimos occaecati natus voluptates quas qui velit.", "Ergonomic Wooden Pants", 293.75m, null },
                    { 10140L, 2L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quis ea qui totam. Quae recusandae aut ut voluptatem molestiae neque. Libero dignissimos molestias non est doloremque. Nihil quasi porro iste cumque. İncidunt esse sed iusto eveniet voluptatem nihil aut blanditiis.", "Refined Metal Ball", 490.55m, null },
                    { 10141L, 2L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "İusto temporibus odit illo. Repudiandae occaecati ut dolor voluptatem voluptatibus est voluptate voluptatem nesciunt. Labore nobis provident nemo accusantium sint. İtaque voluptatem magnam et unde et blanditiis. Eum ex rerum doloribus aut natus.", "Awesome Granite Table", 584.10m, null },
                    { 10142L, 1L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nemo non ut velit cum. Placeat aut dolores dolor aut reiciendis. Quod alias quidem. Excepturi at incidunt eos commodi id qui est cum.", "Intelligent Soft Mouse", 371.07m, null },
                    { 10143L, 1L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptates quia autem nisi doloremque sapiente. Asperiores amet sunt aliquam iure. Ad non non sint saepe architecto quam possimus.", "Fantastic Cotton Salad", 850.30m, null },
                    { 10144L, 1L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "İnventore dolorum sit repellat delectus quod debitis. Voluptates quo tenetur nisi iure eveniet. Totam quis a tempora magnam est incidunt eligendi voluptas eum.", "Rustic Concrete Keyboard", 404.69m, null },
                    { 10145L, 1L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rem asperiores est perferendis. Quod modi optio pariatur atque quis qui doloremque mollitia suscipit. Suscipit sequi non est aut esse natus animi laboriosam. Placeat nihil placeat qui magnam aut quia a. Sit eveniet nihil eum sit voluptatibus aspernatur sit. Aut ipsa recusandae sed atque tempora dignissimos sint.", "Intelligent Fresh Shoes", 56.92m, null },
                    { 10146L, 3L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quia eum quia quo ratione voluptatem commodi vel necessitatibus. Modi et unde praesentium. Alias enim voluptatem.", "Handmade Plastic Bike", 915.30m, null },
                    { 10147L, 1L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptatem eaque qui quis deserunt suscipit. İd sed incidunt aliquid enim in. İn repellendus qui voluptatem vel harum. Et cumque ipsa exercitationem ut officiis quod et tempora vel. Qui sit unde fugit qui illum nemo error voluptate incidunt. Aspernatur nihil iste consequuntur sed nemo.", "Licensed Metal Shoes", 761.14m, null },
                    { 10148L, 3L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Modi rerum quos odio cupiditate harum. Asperiores excepturi et eum quo. Vero quia sed non dolorem. Voluptatem quae explicabo et consectetur sed consequuntur ipsam. A ut qui nulla.", "Refined Cotton Keyboard", 511.87m, null },
                    { 10149L, 3L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Optio dolorem qui nihil ullam est quo alias est aut. Est iusto nemo quam. Aut dicta alias laborum harum. Culpa facilis repudiandae dolorum non dolore est possimus. Aut facilis excepturi assumenda non facere rerum qui est.", "Practical Fresh Gloves", 643.75m, null },
                    { 10150L, 1L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laudantium omnis aut officiis. Et et ipsa voluptas et facere. Doloribus id eaque delectus quis enim. Non sapiente esse aut vel minus. Delectus ea dolor molestiae consequatur cum praesentium et fuga quia. Aut ipsam ut laborum impedit eligendi expedita.", "Licensed Fresh Gloves", 138.67m, null },
                    { 10151L, 3L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ullam nihil quae asperiores occaecati voluptas commodi fugiat et illo. Maiores itaque autem. Dolore qui aut aperiam at et alias natus deleniti. Animi beatae quo sunt ut iste doloremque. Numquam dolorem culpa tempora voluptatem rerum quam est. Sed quam omnis ipsa quasi repellendus iusto laudantium quisquam.", "Handcrafted Concrete Pants", 405.40m, null },
                    { 10152L, 3L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ad non ut vel sit occaecati possimus enim nulla. Aut quia qui consequatur molestiae quo. Ducimus enim possimus placeat tempora ab quos dicta.", "Unbranded Metal Table", 582.85m, null },
                    { 10153L, 1L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Soluta laudantium quisquam dolor. Dolorum eos cum voluptas. Tenetur numquam facilis similique. Tempore beatae doloribus doloribus.", "Rustic Wooden Tuna", 429.05m, null },
                    { 10154L, 2L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nemo porro sed eaque excepturi. Aut non voluptatem quis et ea dolores doloremque. Eum unde eveniet atque doloribus nihil. Qui facere explicabo amet dolores porro architecto incidunt. Voluptatem culpa veritatis.", "Rustic Wooden Tuna", 320.64m, null },
                    { 10155L, 3L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eos repudiandae fugiat. Ea ut saepe ducimus similique pariatur hic aut qui. Qui voluptas et aut error quasi sit laboriosam.", "Fantastic Frozen Salad", 72.21m, null },
                    { 10156L, 2L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "İncidunt saepe non ratione vitae ut ea. Magnam iure ipsum qui ratione perspiciatis rerum. Perspiciatis totam voluptates impedit corporis esse dolores. Voluptatum esse iste aliquid amet eius non consectetur. Qui saepe et eius corporis ut ut.", "Sleek Plastic Shirt", 479.53m, null },
                    { 10157L, 2L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Repudiandae in impedit ut. Pariatur incidunt qui cupiditate dicta sunt et eligendi sequi. Aut sit est quo ullam. Rerum eveniet autem consequatur.", "Generic Cotton Computer", 8.41m, null },
                    { 10158L, 2L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adipisci optio voluptatibus autem est dolorem vel. Placeat vel ipsam. Voluptatem ullam esse ex similique.", "Intelligent Metal Computer", 668.71m, null },
                    { 10159L, 3L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nostrum consectetur magni. Consequatur quod harum praesentium sapiente et molestias ullam tempore iusto. Ea sapiente magnam sit dolores minus a voluptates dignissimos. Est officia occaecati perferendis et ut dignissimos maiores tempore aut. Error nihil autem assumenda dolor consequatur sed. Et culpa cupiditate aliquam sit dolorem.", "Fantastic Concrete Chips", 221.46m, null },
                    { 10160L, 3L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sed quisquam neque. Suscipit iure quaerat. Omnis vel totam temporibus dolorem officia. Est qui et blanditiis explicabo et eos quasi labore et.", "Generic Steel Keyboard", 875.35m, null },
                    { 10161L, 3L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tenetur non consequatur vero omnis facere error. Voluptatem culpa eum. Cumque laboriosam sit quis dolorem. Fugiat eum debitis non eos amet dolores veniam. Et fugiat qui delectus doloribus nisi. Quibusdam itaque non.", "Tasty Concrete Pants", 309.27m, null },
                    { 10162L, 2L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quia veritatis vero cupiditate dolores ipsa fuga odit sunt. Voluptas eaque accusamus illum autem sed quisquam nihil suscipit iure. Corporis libero aliquid nesciunt in error eum.", "Licensed Soft Salad", 657.53m, null },
                    { 10163L, 1L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et saepe ratione totam labore. Nostrum quos nam et nulla. Expedita dolores nobis atque unde porro. Sit et odit est molestiae et natus dicta.", "Awesome Plastic Keyboard", 105.57m, null },
                    { 10164L, 3L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Omnis est et et numquam voluptates veritatis aliquid. Placeat accusamus quis sint repudiandae natus ut recusandae. Quam explicabo eveniet et voluptate et corporis. Maxime ab quae qui ratione quas. Amet minus dolorem quos neque rem non vitae.", "Awesome Rubber Soap", 909.44m, null },
                    { 10165L, 1L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "İste sunt temporibus aliquam rerum veniam nostrum voluptatem ut. Consequatur ullam aut voluptatem in rem sit. Voluptatem distinctio omnis animi.", "Licensed Rubber Gloves", 616.02m, null },
                    { 10166L, 2L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quis eaque magnam voluptas adipisci. Repellendus numquam occaecati rerum ratione aut delectus quis sequi. Est enim vero dolore aliquam temporibus dolor sunt non. Sit voluptatem modi optio omnis necessitatibus.", "Awesome Wooden Keyboard", 196.40m, null },
                    { 10167L, 1L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ea est eum consequatur occaecati occaecati et quae. Libero enim odit quis veritatis accusantium suscipit vel cum quisquam. Voluptatem enim eos nostrum. A et ut eum. Consequatur incidunt debitis voluptatem.", "Intelligent Concrete Towels", 612.86m, null },
                    { 10168L, 2L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Non sed aliquid occaecati. Soluta voluptatem consectetur sapiente asperiores. Dolores enim veritatis. Et sapiente autem dignissimos nemo omnis temporibus ut minima.", "Incredible Wooden Chicken", 752.18m, null },
                    { 10169L, 3L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Molestiae natus quod aut sit. İd id qui autem porro voluptas quasi. Aut iure ut eos et repellendus eveniet deserunt. Eius inventore et nam. Aut et ut natus est sit veritatis quo.", "Practical Soft Bacon", 981.70m, null },
                    { 10170L, 3L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolores dolore eaque. Porro qui quis hic officiis minima doloremque inventore et voluptatem. Quaerat a voluptatem est sunt et temporibus soluta.", "Sleek Rubber Chair", 827.98m, null },
                    { 10171L, 3L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptatem tempora voluptatum. Omnis reprehenderit libero enim corrupti non ipsam. Temporibus quas ullam et exercitationem beatae repellendus molestias qui a. Minus reiciendis sit quia aut accusamus doloremque sapiente nemo. Corrupti sint sit quas. Adipisci quas ipsum.", "Tasty Soft Tuna", 832.84m, null },
                    { 10172L, 1L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quam nisi a eveniet quo est. İpsum nihil sed veritatis eos non omnis est. Dicta quis omnis et qui maiores. İure minima sint qui accusamus ex explicabo rerum voluptatum. Aperiam eum rerum est. Voluptatem vel at sit.", "Licensed Plastic Keyboard", 959.70m, null },
                    { 10173L, 1L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Non ut rerum qui hic in. Et illo sunt dolor modi incidunt labore fugiat enim dicta. Doloribus molestiae numquam tempore repudiandae numquam vitae. Soluta aut deserunt vel sint magni animi. Voluptatum veniam aut voluptas sunt qui omnis rerum quos. Quia dicta quaerat ab officiis ipsa.", "Small Concrete Chips", 341.99m, null },
                    { 10174L, 2L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expedita pariatur ullam et. Sint cupiditate velit. Quia hic blanditiis sapiente nemo laudantium possimus. Debitis labore possimus assumenda neque hic aut sapiente autem accusamus.", "Rustic Soft Tuna", 133.78m, null },
                    { 10175L, 1L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sit nostrum totam est. İd aut dolores. Sit est et quo beatae temporibus. Aut et nobis non totam.", "Sleek Frozen Pizza", 673.20m, null },
                    { 10176L, 2L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nam reiciendis consequatur. Earum eum ut incidunt et eius corrupti cupiditate modi eum. Sit quod blanditiis reprehenderit porro. Officia ad sint corporis quaerat sunt consequatur. Quasi sunt nesciunt et dolores impedit. Non quos quas et tenetur.", "Tasty Fresh Chips", 220.13m, null },
                    { 10177L, 2L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fugiat quia impedit possimus architecto deserunt aspernatur. Ut neque beatae ut repudiandae excepturi optio aut. Reprehenderit expedita ut ipsa. Et totam est hic.", "Small Frozen Cheese", 472.29m, null },
                    { 10178L, 1L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eius eveniet quibusdam dolores saepe. Explicabo architecto ducimus consequatur est assumenda quo non sed. Voluptatum placeat et in tenetur. Hic voluptas ut id saepe odit quisquam. Qui rem laboriosam quo inventore numquam.", "Practical Wooden Chips", 607.75m, null },
                    { 10179L, 2L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "İllo cum aut qui omnis facilis voluptatem. Rerum consectetur eius. Molestiae aspernatur aliquid iste saepe velit in nobis nemo. İllum consequatur et ratione. Rerum dolor maiores officia rerum.", "Handcrafted Soft Ball", 719.34m, null },
                    { 10180L, 3L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delectus quos voluptate. İusto et veritatis qui quod. Ut doloremque beatae commodi vero quo. Blanditiis itaque dolor consectetur et ratione voluptatem debitis cupiditate. İncidunt est quia possimus rerum deleniti.", "Handcrafted Soft Pizza", 646.56m, null },
                    { 10181L, 1L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minima sunt sed et quo corporis. Et similique porro possimus itaque voluptatem consectetur soluta. Et qui repellendus velit consequuntur temporibus magnam voluptas non voluptatem. Quia eos accusantium consequatur.", "Handcrafted Rubber Hat", 377.17m, null },
                    { 10182L, 2L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ab praesentium corrupti expedita et excepturi ad modi dicta unde. Quia et sed. Vel aut ab aspernatur sequi. Et rerum modi illum cumque officia quia repellendus molestiae.", "Gorgeous Wooden Chips", 254.42m, null },
                    { 10183L, 1L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptas ullam eos omnis sit omnis dignissimos dolores autem incidunt. Ullam corrupti voluptatibus laborum. Ut veniam odit officia autem tenetur voluptas ad ratione consequatur. Aliquam consequuntur sint et hic non odit voluptas. Aut commodi provident libero dolorem sapiente et vero.", "Unbranded Rubber Ball", 187.17m, null },
                    { 10184L, 3L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Qui illo dolorum ipsum esse. Accusamus id vero non hic recusandae impedit vitae totam. Quasi et ducimus. Distinctio est ipsa officia quo ea fugiat vero et ipsam. At unde eum amet accusamus natus non autem iste nisi.", "Refined Soft Chips", 68.41m, null },
                    { 10185L, 1L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reiciendis dolorem non occaecati sapiente doloremque totam modi sit. Sunt tenetur perferendis in. Facilis incidunt ratione illum. Delectus maxime dicta vel eaque cum voluptate placeat. Velit et omnis sint enim error et. İn dolores voluptatem alias.", "Rustic Plastic Chair", 815.52m, null },
                    { 10186L, 3L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptas aut nihil dolore in rerum. Eveniet aut soluta debitis sequi cumque. Earum voluptatibus quam est consectetur eius tempore. Minus iure nesciunt. Accusantium officiis ullam.", "Licensed Granite Bacon", 624.15m, null },
                    { 10187L, 3L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ut et explicabo at voluptatem perspiciatis. Est aut repudiandae. Distinctio quia est. Officiis adipisci veniam.", "Unbranded Metal Bacon", 686.32m, null },
                    { 10188L, 1L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beatae commodi illum et rerum alias error. Voluptatem porro placeat. İpsam voluptatem et. Ex voluptatem quasi magni sed esse quas quos. Possimus exercitationem culpa et aliquam et rerum molestiae omnis quisquam.", "Incredible Soft Bike", 563.29m, null },
                    { 10189L, 2L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enim voluptate qui aut aut nam. Possimus natus porro. Reiciendis inventore facere qui vel.", "Licensed Wooden Pants", 404.91m, null },
                    { 10190L, 2L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nihil qui inventore repellendus perferendis qui nesciunt distinctio aliquam atque. Explicabo ipsa quae. Aperiam magnam dolores aut modi ab tempora pariatur voluptatum molestiae. Est et vel repudiandae consequatur similique. Molestiae a consequatur.", "Small Plastic Shirt", 524.43m, null },
                    { 10191L, 1L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolor autem et aut alias. Autem repellendus omnis sed natus. Quaerat ipsam voluptates rerum aperiam. Voluptate eveniet molestiae cum ea ut debitis similique minima.", "Generic Plastic Towels", 186.50m, null },
                    { 10192L, 3L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eum qui nam aut consequuntur consequatur voluptas corporis. Voluptate asperiores tenetur et consequatur illum maiores. Cupiditate voluptatem facere ea voluptatibus voluptatum et sit nulla aspernatur. Enim in alias sint quos ab.", "Awesome Wooden Gloves", 799.12m, null },
                    { 10193L, 1L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aperiam in reiciendis reiciendis in pariatur eum animi. Consequuntur aut corrupti ullam deleniti nesciunt illo rerum. İnventore sint ipsa. Optio consequuntur veniam. Qui et alias.", "Unbranded Soft Gloves", 166.17m, null },
                    { 10194L, 3L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cumque facilis expedita sed perspiciatis architecto sed. Error odio dignissimos voluptates expedita et beatae tenetur. Dignissimos reiciendis est optio non quisquam voluptatibus est earum aut. Consequuntur cum rerum. İste voluptatem similique deserunt aut. Corporis rem possimus et corporis omnis impedit doloribus quia quaerat.", "Refined Wooden Salad", 864.04m, null },
                    { 10195L, 1L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Molestiae molestiae laudantium. Optio beatae aut deleniti autem doloremque et. Ut eos inventore autem repellendus voluptas deserunt ut tempora ut. Vitae aut autem. Quisquam nemo laudantium similique vitae sit vel nemo.", "Fantastic Steel Pizza", 892.85m, null },
                    { 10196L, 2L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolor enim officiis enim earum perferendis enim earum eius ut. Eum quos non maxime et ex id. Totam perspiciatis ut incidunt suscipit autem maiores. Earum veniam laboriosam quidem quaerat ea perspiciatis. Autem impedit enim numquam enim atque ea nobis. Qui quas iure facilis est consequatur eius suscipit.", "Gorgeous Frozen Pants", 893.31m, null },
                    { 10197L, 3L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Necessitatibus quod voluptatem. Sed velit cumque rerum dicta. Eum rerum fugiat qui ipsum eum vel quaerat aut. Quis est animi. Facere autem id qui.", "Licensed Soft Car", 696.84m, null },
                    { 10198L, 2L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptatem ex et. Consequatur officiis at consequatur. Quis nihil ea.", "Gorgeous Soft Bike", 214.95m, null },
                    { 10199L, 2L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quis sit ut rem. Delectus enim repellat molestiae enim eum excepturi id quis. Quam hic quaerat sunt vel nemo ea velit. Officiis laboriosam omnis quibusdam eius eaque neque non sunt.", "Gorgeous Fresh Sausages", 556.57m, null },
                    { 10200L, 3L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doloremque error at est eveniet et aut. Dolor eveniet ut sed qui blanditiis facilis consectetur nemo. Qui sit aperiam ea eaque ut architecto aspernatur dolores. İllum adipisci dolor. Magni quasi esse voluptatibus temporibus quisquam alias reprehenderit voluptatibus. Tempora repellat mollitia pariatur sed magnam et.", "Sleek Cotton Chicken", 838.81m, null },
                    { 10201L, 1L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Natus repellendus rerum. Non distinctio eum sed dolorum facilis dolorum magni magnam. Voluptas officia et porro repellat. Quia iure occaecati non sit.", "Handmade Granite Fish", 131.80m, null },
                    { 10202L, 1L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vel adipisci ut deleniti nam nesciunt ratione a. Facilis quisquam earum quia quia magni est sit ea. Repellendus dolorem nihil iure aut quidem. Corrupti culpa alias id exercitationem recusandae itaque sunt. Voluptas ut dolores libero non.", "Handmade Rubber Computer", 570.73m, null },
                    { 10203L, 3L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Suscipit et vero inventore qui. Ut exercitationem illo illum. Mollitia aut quo ad.", "Ergonomic Soft Salad", 915.87m, null },
                    { 10204L, 3L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Temporibus est ratione fuga corporis aliquid aut. Excepturi dolore et aperiam qui officia. İpsam enim culpa. Veniam qui saepe incidunt quae.", "Awesome Granite Gloves", 875.83m, null },
                    { 10205L, 1L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Est mollitia perspiciatis sed. Voluptas voluptatem commodi. Qui dolores praesentium.", "Fantastic Granite Cheese", 902.19m, null },
                    { 10206L, 1L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quae sint suscipit est sapiente molestias. Qui ut consequatur occaecati sunt doloribus est. Est repudiandae quam ut in voluptatem magnam consequuntur. Non rerum officiis deserunt nihil suscipit aut facere.", "Rustic Frozen Table", 440.77m, null },
                    { 10207L, 2L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eius officia minus ut similique necessitatibus et quo est. Ut velit officia occaecati quo autem quis. Sapiente optio possimus quas. Aliquid ea vel est. Rerum quisquam est. Exercitationem repellendus porro.", "Intelligent Soft Salad", 107.89m, null },
                    { 10208L, 2L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quas repellendus omnis qui tempora dolores mollitia. Repudiandae officiis quia sed ab saepe sed. Dolor dolores sit alias inventore fugiat ut minima earum. Animi natus et magnam ea voluptates molestiae tempora consequatur.", "Tasty Metal Shoes", 204.28m, null },
                    { 10209L, 1L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dignissimos est fuga tempore reprehenderit ipsam alias quia nesciunt. Magni nemo asperiores. Rerum aut sed qui est sint dolorum ea dolorem et. Explicabo sit et eligendi aut maiores qui. Saepe cupiditate laudantium earum occaecati molestiae.", "Handmade Cotton Gloves", 862.80m, null },
                    { 10210L, 2L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et voluptate sapiente laudantium nulla et assumenda. Est vel blanditiis aut et minima et odio delectus quis. Aut nesciunt non cupiditate quod pariatur quasi eum. Placeat autem iste aliquam et quis earum corporis tempore ab.", "Awesome Steel Keyboard", 551.73m, null },
                    { 10211L, 2L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Modi ea exercitationem ipsam harum labore. Unde sint impedit nemo eligendi quo voluptatem consequuntur. Quam dolor blanditiis est minus consequatur inventore aut rem odit. Et voluptatem enim mollitia labore quo et incidunt qui ut.", "Intelligent Frozen Ball", 210.83m, null },
                    { 10212L, 3L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quis consequuntur labore non. Rerum nam consequatur consectetur tempora maxime hic voluptatem voluptatem. Non quis excepturi. Placeat nulla rerum. Quasi expedita autem rerum molestias quia qui.", "Handcrafted Frozen Bike", 217.48m, null },
                    { 10213L, 3L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Earum aut iure in minus consectetur quia accusamus voluptatem quaerat. Quo praesentium consequuntur quibusdam aut non quidem ea. İmpedit deserunt omnis harum alias occaecati repudiandae corrupti. Beatae voluptas tempore atque et sint sint explicabo libero rerum. Deserunt sed est eum repellat id voluptatibus sit dolor. Esse et aut temporibus sit.", "Handmade Granite Hat", 493.24m, null },
                    { 10214L, 1L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Perferendis repellendus earum autem illum ut beatae exercitationem repudiandae iure. Adipisci ullam ad est itaque. Quod doloribus sit. Alias fugit quo neque magni nemo doloribus qui. Ullam quam ut dolore rerum.", "Refined Frozen Shoes", 369.85m, null },
                    { 10215L, 2L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "İncidunt ea molestiae. Esse ad corporis soluta voluptatibus unde at cum. Ab et et tempore incidunt qui nihil. Quae aliquid deleniti velit animi eius quasi veniam rerum.", "Fantastic Fresh Pizza", 525.94m, null },
                    { 10216L, 2L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Omnis odit qui ipsa fugit veritatis. İd sit quo. Dolores eveniet provident nulla id.", "Unbranded Concrete Hat", 78.30m, null },
                    { 10217L, 2L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptates tempore qui doloribus aut delectus. Alias quia nostrum cupiditate voluptas incidunt autem veritatis aut. Accusantium molestiae iusto. Est assumenda autem voluptas. Maxime iure ut perferendis voluptatem et ducimus fugiat minus hic.", "Rustic Frozen Fish", 388.36m, null },
                    { 10218L, 2L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quia aut ea. Sunt consequuntur et quae consequatur sunt distinctio. Non velit ut.", "Generic Fresh Bike", 23.27m, null },
                    { 10219L, 1L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Repudiandae explicabo ad voluptate architecto et eum. Earum officiis harum iste magni quae distinctio sequi pariatur facilis. İd tempora aut quidem omnis. Ut suscipit dolore iusto nulla corrupti qui nihil dolor aut. Et aperiam doloremque non repudiandae pariatur dolor quod. Adipisci omnis ea omnis.", "Awesome Cotton Hat", 997.29m, null },
                    { 10220L, 2L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quia et sint labore expedita quia qui maiores. İpsam saepe sit animi esse iste repellat. Accusamus sit reiciendis ut odio ab qui facilis.", "Small Steel Ball", 80.73m, null },
                    { 10221L, 3L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Commodi dolorum reprehenderit adipisci molestiae accusamus aut. Quod omnis error aut. Earum laboriosam cum ut nostrum praesentium. Eligendi ipsum incidunt eos qui facere id debitis quae a. Eum vitae aut.", "Handcrafted Rubber Pants", 43.15m, null },
                    { 10222L, 2L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eos aut doloribus. Enim aut aut esse odio alias alias similique iusto. Voluptates animi soluta dolorem mollitia. Vitae vero consequatur excepturi unde quo possimus rerum.", "Refined Frozen Gloves", 1.76m, null },
                    { 10223L, 3L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sint asperiores similique eveniet ea ut quibusdam. Possimus modi corporis quis non perspiciatis aliquid hic distinctio. Dolores impedit dolorem architecto eos et praesentium molestiae. Voluptatem consequatur recusandae voluptates vitae voluptas dignissimos unde. Quis temporibus dolorum corrupti et magnam tenetur ex voluptate necessitatibus. Voluptatem alias voluptatem.", "Handmade Plastic Shirt", 438.54m, null },
                    { 10224L, 1L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Labore corporis quia qui et possimus eos libero unde. Veniam provident ab quia enim consequatur aut. Asperiores dignissimos unde amet et corporis. Distinctio occaecati id voluptatem. Nemo voluptatem cumque autem quia incidunt qui.", "Generic Cotton Gloves", 130.35m, null },
                    { 10225L, 2L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolor esse est facere quo non nesciunt alias. Doloribus assumenda consectetur qui at pariatur culpa et dolorum quis. Sit nesciunt excepturi quasi molestiae atque.", "Intelligent Rubber Soap", 56.66m, null },
                    { 10226L, 2L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accusamus fuga ab et qui recusandae. Aut aliquid commodi quasi. Laboriosam repellat facere libero et atque nobis harum distinctio. Adipisci velit aliquid vel corporis commodi quia architecto.", "Refined Metal Chips", 597.75m, null },
                    { 10227L, 1L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Facilis ullam error at et sit aut voluptate qui dolorem. Non accusamus et voluptas beatae sequi hic excepturi deserunt repellendus. Culpa ut eos qui quaerat nihil officiis vitae molestias. Commodi consectetur suscipit quod quis ut ut voluptas. Accusantium dolores et quia numquam ducimus corporis. İd voluptate eveniet.", "Rustic Rubber Ball", 139.73m, null },
                    { 10228L, 2L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Est adipisci dolorem cumque ipsum est unde est nihil. Reprehenderit quia ab ut quibusdam veritatis asperiores odit. Amet perspiciatis ea tenetur sunt quae in officia eveniet. Reiciendis maxime repellendus est officia veritatis eius. Qui quia qui in dolorem cupiditate. Praesentium tempore provident voluptatem architecto quasi praesentium.", "Fantastic Steel Shoes", 652.09m, null },
                    { 10229L, 2L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "İusto unde dicta. Nihil quis eligendi est. Est autem culpa occaecati.", "Refined Granite Pants", 774.69m, null },
                    { 10230L, 3L, 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Repudiandae quidem quo fuga vitae ut aut. Et voluptatem quam dicta. Quibusdam ipsum autem blanditiis quis.", "Handmade Plastic Towels", 756.96m, null },
                    { 10231L, 1L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolores doloremque beatae autem doloribus et. Porro distinctio officia reiciendis aut. Sed reiciendis et nobis beatae ratione corporis sed.", "Gorgeous Soft Salad", 823.65m, null }
                });

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 16, 15, 13, 150, DateTimeKind.Local).AddTicks(9784));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 16, 15, 13, 150, DateTimeKind.Local).AddTicks(9790));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Type",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 16, 15, 13, 151, DateTimeKind.Local).AddTicks(8084));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Type",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 16, 15, 13, 151, DateTimeKind.Local).AddTicks(8095));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Type",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 16, 15, 13, 151, DateTimeKind.Local).AddTicks(8096));

            migrationBuilder.InsertData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                columns: new[] { "Id", "CatalogItemId", "CreatedDate", "FileName", "IsHeader", "Path", "UpdatedDate" },
                values: new object[,]
                {
                    { 20028L, 10093L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20029L, 10129L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20030L, 10095L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20031L, 10069L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20032L, 10149L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20033L, 10080L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20034L, 10224L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20035L, 10065L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20036L, 10106L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20037L, 10219L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20038L, 10057L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20039L, 10190L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20040L, 10230L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20041L, 10037L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20042L, 10114L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20043L, 10152L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20044L, 10225L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20045L, 10141L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20046L, 10084L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20047L, 10096L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20048L, 10082L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20049L, 10041L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20050L, 10211L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20051L, 10091L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20052L, 10034L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20053L, 10140L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20054L, 10120L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20055L, 10152L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20056L, 10206L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20057L, 10208L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20058L, 10060L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20059L, 10156L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20060L, 10060L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20061L, 10075L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20062L, 10150L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20063L, 10086L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20064L, 10033L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20065L, 10189L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20066L, 10204L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20067L, 10034L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20068L, 10225L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20069L, 10186L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20070L, 10108L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20071L, 10124L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20072L, 10057L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20073L, 10216L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20074L, 10192L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20075L, 10083L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20076L, 10078L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20077L, 10087L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20078L, 10204L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20079L, 10157L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20080L, 10182L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20081L, 10067L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20082L, 10053L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20083L, 10048L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20084L, 10115L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20085L, 10055L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20086L, 10195L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20087L, 10126L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20088L, 10116L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20089L, 10038L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20090L, 10083L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20091L, 10135L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20092L, 10054L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20093L, 10090L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20094L, 10040L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20095L, 10222L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20096L, 10076L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20097L, 10073L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20098L, 10129L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20099L, 10118L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20100L, 10199L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20101L, 10066L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20102L, 10187L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20103L, 10081L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20104L, 10185L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20105L, 10072L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20106L, 10222L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20107L, 10101L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20108L, 10112L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20109L, 10219L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20110L, 10042L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20111L, 10122L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20112L, 10126L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20113L, 10196L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20114L, 10201L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20115L, 10044L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20116L, 10086L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20117L, 10097L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20118L, 10046L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20119L, 10118L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20120L, 10076L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20121L, 10065L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20122L, 10161L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20123L, 10127L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20124L, 10224L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20125L, 10057L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20126L, 10087L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20127L, 10210L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20128L, 10168L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20129L, 10035L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20130L, 10146L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20131L, 10048L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20132L, 10191L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20133L, 10036L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20134L, 10055L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20135L, 10124L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20136L, 10188L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20137L, 10048L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20138L, 10178L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20139L, 10134L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20140L, 10134L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20141L, 10076L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20142L, 10221L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20143L, 10069L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20144L, 10152L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20145L, 10228L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20146L, 10156L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20147L, 10035L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20148L, 10229L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20149L, 10217L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20150L, 10096L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20151L, 10171L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20152L, 10116L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20153L, 10166L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20154L, 10171L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20155L, 10072L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20156L, 10205L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20157L, 10072L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20158L, 10191L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20159L, 10214L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20160L, 10120L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20161L, 10104L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20162L, 10215L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20163L, 10087L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20164L, 10212L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20165L, 10221L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20166L, 10199L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20167L, 10106L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20168L, 10069L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20169L, 10196L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20170L, 10043L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20171L, 10111L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20172L, 10158L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20173L, 10220L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20174L, 10211L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20175L, 10180L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20176L, 10174L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20177L, 10094L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20178L, 10115L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20179L, 10078L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20180L, 10192L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20181L, 10152L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20182L, 10056L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20183L, 10177L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20184L, 10127L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20185L, 10123L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20186L, 10145L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20187L, 10164L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20188L, 10116L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20189L, 10168L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20190L, 10134L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20191L, 10084L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20192L, 10197L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20193L, 10146L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20194L, 10210L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20195L, 10150L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20196L, 10215L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20197L, 10037L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20198L, 10090L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20199L, 10048L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20200L, 10082L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20201L, 10207L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20202L, 10183L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20203L, 10091L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20204L, 10192L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20205L, 10068L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20206L, 10079L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20207L, 10138L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20208L, 10215L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20209L, 10216L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20210L, 10182L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20211L, 10218L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20212L, 10196L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20213L, 10160L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20214L, 10068L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20215L, 10186L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20216L, 10118L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20217L, 10057L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20218L, 10098L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20219L, 10212L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20220L, 10130L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20221L, 10118L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20222L, 10060L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20223L, 10121L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20224L, 10180L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20225L, 10064L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20226L, 10055L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null },
                    { 20227L, 10229L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "akbey.jpg", true, "v1671933877/shoes/akbey_qqopy0", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10032L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10039L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10045L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10047L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10049L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10050L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10051L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10052L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10058L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10059L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10061L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10062L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10063L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10070L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10071L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10074L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10077L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10085L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10088L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10089L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10092L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10099L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10100L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10102L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10103L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10105L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10107L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10109L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10110L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10113L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10117L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10119L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10125L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10128L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10131L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10132L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10133L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10136L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10137L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10139L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10142L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10143L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10144L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10147L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10148L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10151L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10153L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10154L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10155L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10159L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10162L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10163L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10165L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10167L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10169L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10170L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10172L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10173L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10175L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10176L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10179L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10181L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10184L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10193L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10194L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10198L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10200L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10202L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10203L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10209L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10213L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10223L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10226L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10227L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10231L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20028L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20029L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20030L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20031L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20032L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20033L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20034L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20035L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20036L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20037L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20038L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20039L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20040L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20041L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20042L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20043L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20044L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20045L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20046L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20047L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20048L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20049L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20050L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20051L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20052L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20053L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20054L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20055L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20056L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20057L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20058L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20059L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20060L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20061L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20062L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20063L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20064L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20065L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20066L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20067L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20068L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20069L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20070L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20071L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20072L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20073L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20074L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20075L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20076L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20077L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20078L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20079L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20080L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20081L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20082L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20083L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20084L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20085L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20086L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20087L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20088L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20089L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20090L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20091L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20092L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20093L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20094L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20095L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20096L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20097L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20098L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20099L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20100L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20101L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20102L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20103L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20104L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20105L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20106L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20107L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20108L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20109L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20110L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20111L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20112L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20113L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20114L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20115L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20116L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20117L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20118L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20119L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20120L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20121L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20122L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20123L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20124L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20125L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20126L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20127L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20128L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20129L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20130L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20131L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20132L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20133L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20134L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20135L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20136L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20137L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20138L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20139L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20140L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20141L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20142L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20143L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20144L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20145L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20146L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20147L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20148L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20149L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20150L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20151L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20152L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20153L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20154L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20155L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20156L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20157L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20158L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20159L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20160L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20161L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20162L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20163L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20164L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20165L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20166L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20167L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20168L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20169L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20170L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20171L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20172L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20173L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20174L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20175L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20176L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20177L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20178L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20179L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20180L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20181L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20182L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20183L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20184L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20185L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20186L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20187L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20188L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20189L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20190L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20191L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20192L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20193L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20194L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20195L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20196L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20197L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20198L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20199L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20200L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20201L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20202L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20203L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20204L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20205L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20206L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20207L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20208L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20209L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20210L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20211L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20212L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20213L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20214L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20215L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20216L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20217L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20218L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20219L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20220L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20221L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20222L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20223L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20224L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20225L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20226L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 20227L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10033L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10034L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10035L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10036L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10037L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10038L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10040L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10041L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10042L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10043L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10044L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10046L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10048L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10053L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10054L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10055L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10056L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10057L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10060L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10064L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10065L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10066L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10067L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10068L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10069L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10072L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10073L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10075L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10076L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10078L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10079L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10080L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10081L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10082L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10083L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10084L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10086L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10087L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10090L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10091L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10093L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10094L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10095L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10096L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10097L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10098L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10101L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10104L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10106L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10108L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10111L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10112L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10114L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10115L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10116L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10118L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10120L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10121L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10122L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10123L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10124L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10126L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10127L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10129L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10130L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10134L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10135L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10138L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10140L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10141L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10145L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10146L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10149L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10150L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10152L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10156L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10157L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10158L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10160L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10161L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10164L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10166L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10168L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10171L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10174L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10177L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10178L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10180L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10182L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10183L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10185L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10186L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10187L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10188L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10189L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10190L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10191L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10192L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10195L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10196L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10197L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10199L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10201L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10204L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10205L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10206L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10207L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10208L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10210L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10211L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10212L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10214L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10215L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10216L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10217L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10218L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10219L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10220L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10221L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10222L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10224L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10225L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10228L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10229L);

            migrationBuilder.DeleteData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 10230L);

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Brand",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 3, 12, 42, 475, DateTimeKind.Local).AddTicks(4737));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Brand",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 3, 12, 42, 475, DateTimeKind.Local).AddTicks(4753));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Brand",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 3, 12, 42, 475, DateTimeKind.Local).AddTicks(4755));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 3, 12, 42, 476, DateTimeKind.Local).AddTicks(3026));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 3, 12, 42, 476, DateTimeKind.Local).AddTicks(3034));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 3, 12, 42, 476, DateTimeKind.Local).AddTicks(5686));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 3, 12, 42, 476, DateTimeKind.Local).AddTicks(5691));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Type",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 3, 12, 42, 477, DateTimeKind.Local).AddTicks(4987));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Type",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 3, 12, 42, 477, DateTimeKind.Local).AddTicks(5001));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Type",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 3, 12, 42, 477, DateTimeKind.Local).AddTicks(5002));
        }
    }
}
