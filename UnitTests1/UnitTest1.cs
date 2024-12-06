using NUnit.Framework;
using BlazorAppClientServer.Client.Services;
using BlazorAppClientServer.Shared.Models;
using System.Net;
using Microsoft.Identity.Client;
using Moq;
using System;
using Castle.Components.DictionaryAdapter;

namespace BlazorAppClientServer.Tests
{
        [TestFixture]
        public class YdelseTests
        {
            private Ydelse _ydelse;

            [SetUp]
            public void Setup()
            {
                // Initialisering af Ydelse objektet
                _ydelse = new Ydelse
                {
                    YdelseId = 1,
                    Navn = "Reparation",
                    Pris = 500.0,
                    Art = "Service",
                    Timer = 2.5
                };
            }

            // Test af korrekt initialisering af Ydelse objektet
            [Test]
            public void Ydelse_ShouldBeInitializedCorrectly()
            {
                // Act
                var result = _ydelse;

                // Assert
                Assert.NotNull(result);
                Assert.AreEqual(1, result.YdelseId);
                Assert.AreEqual("Reparation", result.Navn);
                Assert.AreEqual(500.0, result.Pris);
                Assert.AreEqual("Service", result.Art);
                Assert.AreEqual(2.5, result.Timer);
            }

            // Test af ToString metoden
            [Test]
            public void Ydelse_ToString_ShouldReturnCorrectString()
            {
                // Act
                var result = _ydelse.ToString();

                // Assert
                Assert.AreEqual("Reparation", result);
            }
        }
}

