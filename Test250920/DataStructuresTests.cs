using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test250920
{
    /* NuGet 패키지를 추가하는 방법! */
    /*  솔루션 탐색기에서 프로젝트(Test250920)를 마우스 오른쪽 클릭합니다. 
     *  'NuGet 패키지 관리'를 선택합니다. 
     *  '찾아보기'탭에서 원하는 패키지를 검색합니다. 
     *  '설치'를 클릭해 프로젝트에 추가합니다. */

    /* 테스트 프레임워크 */
    /*  NUnit이나 xUnit과 같은 단위 테스트 프레임워크는 
     *  테스트를 작성하고 실행할 수 있게 하여 
     *  코드가 예상대로 작동하는지 조기에 식별할 수 있도록 합니다. */
    
    /* Test 실행 방법! */
    /*  테스트 > 테스트 탐색기 에서 테스트를 실행하거나 
     *  터미널에서 명령어( dotnet test )를 입력하여 실행할 수 있습니다. */

    [TestClass] //MSTest 프레임워크에서 제공하는 테스트용 어트리뷰트
    public class DataStructuresTests
    {
        [TestMethod]    //MSTest에서 테스트 메서드로 인식.
        public void TestStackPush()
        {
            // 해당 test case
        }
    }

    [TestFixture] // NUnit에서 테스트 클래스
    public class Tests
    {
        [Test]     // NUnit에서 테스트 메서드
        public void PrintMsg()
        {
            // test case
        }
    }
}
