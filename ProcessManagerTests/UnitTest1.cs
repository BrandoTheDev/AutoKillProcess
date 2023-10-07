using AutoKillProcess;
using Moq;
using NUnit.Framework;
using System.Diagnostics;

namespace ProcessManagerTests
{
    public class Tests
    {

        [Test]
        public void GetProcessList_ReturnsNonEmptyList()
        {
            var processes = ProcessManager.GetProcessList();

            Assert.IsNotEmpty(processes);
            Assert.IsNotNull(processes);
        }

    }
}