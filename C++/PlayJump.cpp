#include iostream
#include vector

using namespace std;

bool canJump(vectorint& nums) {
	int reachable = 0;

	for (int i = 0; i  nums.size(); i++) {
		if (i  reachable) {
			return false;
		}
		reachable = max(reachable, i + nums[i]);
	}
	return true;
}


int main()
{
	vectorint nums = { 2,3,1,1,4 };

	canJump(nums)  cout  Jump  cout  No jump;
	return 0;
}

