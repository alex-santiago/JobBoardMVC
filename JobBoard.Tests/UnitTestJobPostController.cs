using System.Collections.Generic;
using System.Linq;
using Moq;
using JobBoard.Controllers;
using JobBoard.Models;
using System;
using Xunit;

namespace JobBoard.Tests
{
    public class UnitTestJobPostController
    {
        [Fact]
        public void Can_Paginate()
        {
            // Arrange
            Mock<IJobPostRepository> mock = new Mock<IJobPostRepository>();
            mock.Setup(m => m.JobPosts).Returns(new JobPost[] {
                new JobPost { JobPostID = 1, Title = "JP1", PostDate = new DateTime(2018, 3, 1)},
                new JobPost { JobPostID = 2, Title = "JP2", PostDate = new DateTime(2018, 3, 2)},
                new JobPost { JobPostID = 3, Title = "JP3", PostDate = new DateTime(2018, 3, 3)},
                new JobPost { JobPostID = 4, Title = "JP4", PostDate = new DateTime(2018, 3, 4)},
                new JobPost { JobPostID = 5, Title = "JP5", PostDate = new DateTime(2018, 3, 5)},
                new JobPost { JobPostID = 6, Title = "JP6", PostDate = new DateTime(2018, 3, 6)},
                new JobPost { JobPostID = 7, Title = "JP7", PostDate = new DateTime(2018, 3, 7)},
                new JobPost { JobPostID = 8, Title = "JP8", PostDate = new DateTime(2018, 3, 8)},
                new JobPost { JobPostID = 9, Title = "JP9", PostDate = new DateTime(2018, 3, 9)}
            });

            JobPostController controller = new JobPostController(mock.Object);
            controller.PageSize = 6;

            // Act
            IEnumerable<JobPost> result = controller.List(2).ViewData.Model as IEnumerable<JobPost>;

            //Assert
            JobPost[] jobPostArray = result.ToArray();
            Assert.True(jobPostArray.Length == 3);
            Assert.Equal("JP7", jobPostArray[0].Title);
            Assert.Equal("JP8", jobPostArray[1].Title);
            Assert.Equal("JP9", jobPostArray[2].Title);
        }
    }
}
