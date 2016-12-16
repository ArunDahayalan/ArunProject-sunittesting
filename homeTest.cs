using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using interview1.test.Controller;
using interview1.test;
using interview1.Models;
namespace interview1.test.Model
{
    class homeTest
    {
        [Test]
        public void BookList_UserViewList_ReturnsBooksList()
        {
            //Arrange
            represent representModel = new represent();

            //Act
            var bookList = representModel.bookListFromTable();

            //Assert
            Assert.IsNotNull(bookList);
        }
        [Test]
        public void BookUpdate_UserAddBook_ReturnsBooksDetail()
        {
            //Arrange
            represent representModel = new represent();
            ReleaseBuild values = new ReleaseBuild();
            values.Author="Tester";
            values.Name = "TestBook";
            values.Number = 22222;
            values.Language = "c#";

            //Act
            var bookList = representModel.updateValues(values);

            //Assert
            Assert.IsNotNull(bookList);
        }
        [Test]
        [ExpectedException("System.Data.Entity.DbUpdateException")]
        public void BookUpdate_UserAddBookNullBookNumber_ReturnsUpdateexception()
        {
            //Arrange
            represent representModel = new represent();
            ReleaseBuild values = new ReleaseBuild();
            values.Author = "Tester";
            values.Name = "TestBook";
            values.Language = "c#";

            //Act
            var bookList = representModel.updateValues(values);

            //Assert
            Assert.IsNotNull(bookList);
        }

        [Test]
        [ExpectedException("System.Data.Entity.DbUpdateException")]
        public void BookUpdate_UserAddBookNullBookName_ReturnsUpdateexception()
        {
            //Arrange
            represent representModel = new represent();
            ReleaseBuild values = new ReleaseBuild();
            values.Author = "Tester";
            values.Number = 22222;
            values.Language = "c#";

            //Act
            var bookList = representModel.updateValues(values);

            //Assert
            Assert.IsNotNull(bookList);
        }
        [Test]
        [ExpectedException("System.Data.Entity.DbUpdateException")]
        public void BookUpdate_UserAddBookNullBookAuthor_ReturnsUpdateexception()
        {
            //Arrange
            represent representModel = new represent();
            ReleaseBuild values = new ReleaseBuild();
            values.Number = 22222;
            values.Language = "c#";
            values.Name = "TestBook";

            //Act
            var bookList = representModel.updateValues(values);

            //Assert
            Assert.IsNotNull(bookList);
        }
        [Test]
        [ExpectedException("System.Data.Entity.DbUpdateException")]
        public void BookUpdate_UserAddBookNullBookLanguageAndAuthor_ReturnsUpdateexception()
        {
            //Arrange
            represent representModel = new represent();
            ReleaseBuild values = new ReleaseBuild();
            values.Number = 22222;
            values.Name = "TestBook";

            //Act
            var bookList = representModel.updateValues(values);

            //Assert
            Assert.IsNotNull(bookList);
        }
        [Test]
        public void BookDetail_UserViewSingleBookDetail_ReturnBookValues()
        {
            //Arrange
            represent representModel = new represent();
            var id = 5;
            var expectedBookName = "Php";
            var expectedBookAuthor = "Paruthi";
            var expectedBookLanguasge = "c#";
            var expectedBookNumber = 1115;
            //Act
            var bookList = representModel.singleBookDetails(id);

            //Assert
            Assert.IsNotNull(bookList);
            Assert.AreSame(bookList.Name, expectedBookName);
            Assert.AreSame(bookList.Author, expectedBookAuthor);
            Assert.AreSame(bookList.Language, expectedBookLanguasge);
            Assert.AreSame(bookList.Number, expectedBookNumber);
        }
        [Test]
        public void BookDetail_UserViewSingleBookDetail_ReturnBookValuesasNull()
        {
            //Arrange
            represent representModel = new represent();
            var id = 0;
            //Act
            var bookList = representModel.singleBookDetails(id);

            //Assert
            Assert.IsNull(bookList);
        }
    }
}
