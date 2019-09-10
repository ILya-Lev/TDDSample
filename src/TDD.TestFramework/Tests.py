from TDD_TestFramework import WasRun
from TDD_TestFramework import TestCase

class TestCaseTest(TestCase):
	def testRunning(self):
		test = WasRun("testMethod")
		assert (not test.wasRun)
		test.run()
		assert (test.wasRun)


TestCaseTest("testRunning").run()

