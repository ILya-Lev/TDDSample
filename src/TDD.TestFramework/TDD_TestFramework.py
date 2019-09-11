class TestCase : 
	def __init__(self, name):
		self.methodUnderTheTest = name
		self.resultSatistics = TestResult()	

	def run(self):
		self.setUp()
		method = getattr(self, self.methodUnderTheTest)
		self.resultSatistics.testStarted()
		method()
		self.tearDown()
		return self.resultSatistics

	def setUp(self): pass
	def tearDown(self): pass

#was run class inherits test case class
class WasRun(TestCase) : 
	def __init__(self, name):
		TestCase.__init__(self, name)		#why calling base ctor is done after body of derived one?
	def testMethod(self): 
		self.log += " testMethod"
	def setUp(self):
		self.log = "setUp"
	def tearDown(self):
		self.log += " tearDown"
	def testBrokenMethod(self):
	   raise Exception

class TestResult: 
	def __init__(self):
		self.runCount = 0
	
	def testStarted(self):
		self.runCount += 1

	def summary(self):
		return "%d run, 0 failed" %self.runCount