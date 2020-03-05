using System;
using Xunit;
using Shouldly;
using TestStack.BDDfy;

namespace Chromadream.DefaultParser.Tests
{
    public class ParserUnitTest
    {

        private string _toParse;
        private Int32 _expected;
        private Int32 _actual;
        [Fact]
        public void ShouldRunSuccessfully()
        {
            this.Given(x => AValidStringToParse())
                .When(x => DefaultParserIsUsed())
                .Then(x => CorrectValueShouldBeReturned())
                .BDDfy();
        }

        [Fact]
        public void ShouldReturnDefaultValue()
        {
            this.Given(x => AnInvalidStringToParse())
                .When(x => DefaultParserIsUsed())
                .Then(x => DefaultValueShouldBeReturned())
                .BDDfy();
        }


        #region Given
            private void AValidStringToParse()
            {
                _toParse = "3";
                _expected = 3;
            }

            private void AnInvalidStringToParse()
            {
                _toParse = "x";
                _expected = default(int);
            }
        #endregion

        #region When
            private void DefaultParserIsUsed()
            {
                _actual = DefaultParser.Parse<Int32>(_toParse);
            }
        #endregion

        #region Then
            private void CorrectValueShouldBeReturned()
            {
                _actual.ShouldBe(_expected);
            }

            private void DefaultValueShouldBeReturned()
            {
                _actual.ShouldBe(_expected);
            }
        #endregion
    }
}
