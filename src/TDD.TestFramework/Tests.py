from TDD_TestFramework import WasRun
from TDD_TestFramework import TestCase

class TestCaseTest(TestCase):

	def testTemplateMethod(self):
		test = WasRun("testMethod")
		
		test.run()
		
		print (test.log)
		assert (test.log == "setUp testMethod tearDown")


TestCaseTest("testTemplateMethod").run()

