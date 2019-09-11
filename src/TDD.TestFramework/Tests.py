from TDD_TestFramework import WasRun
from TDD_TestFramework import TestCase

class TestCaseTest(TestCase):
	def setUp(self):
		self.test = WasRun("testMethod")
		
	def testTemplateMethod(self):
		self.test.run()
		
		print (self.test.log)
		assert (self.test.log == "setUp testMethod tearDown")

	def testResult(self):
		result = self.test.run()

		print (result.summary())
		assert("1 run, 0 failed" == result.summary())
	
	def testFailedResutl(self):
		test = WasRun("testBrokenMethod")
		
		result = test.run()
		
		print (result.summary())
		assert("1 run, 1 failed" == result.summary())


TestCaseTest("testTemplateMethod").run()
TestCaseTest("testResult").run()
TestCaseTest("testFailedResutl").run()

